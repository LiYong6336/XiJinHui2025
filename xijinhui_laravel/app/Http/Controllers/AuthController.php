<?php

namespace App\Http\Controllers;

use App\Models\SettingMenu;
use App\Models\User;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;
use Illuminate\Support\Facades\Auth;
use Illuminate\Foundation\Validation\ValidatesRequests;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;


class AuthController extends Controller
{

    /**
     * Register api
     *
     * @return \Illuminate\Http\Response
     */
    public function register(Request $request): JsonResponse
    {
        $validateData = Validator::make($request->all(), [
            'name' => 'required|min:4|max:255',
            'username' => 'required|alpha_dash|min:4|max:255|unique:users',
            'phone' => 'required|alpha_dash|min:9|max:10|unique:users',
            'password' => 'required|min:3|max:125|',
            'c_password' => 'required|same:password'
        ]);


        if ($validateData->fails()) {
            return HelperController::modelOperationErrorMessage($validateData->errors()); //return error message
        }
        $emailAddress = $request['phone'] . '@chuanmapoth.com';
        $input = $request->all();
        $input['password'] = bcrypt($input['password']);


        $user = User::create($input);
        $success['token'] = $user->createToken('ChuanMaPo')->plainTextToken;
        $success['name'] = $user->name;


        return HelperController::modelCretedSuccessfuleMessage($success, 'User register successfully.');
    }

    /**
     * Login api
     *
     * @return \Illuminate\Http\Response
     */
    public function login(Request $request): JsonResponse
    {
        if (
            //Auth::attempt(['phone' => $request->phone, 'password' => trim($request->password)]) ||
            Auth::attempt(['username' => $request->phone, 'password' => trim($request->password)]) ||
            Auth::attempt(['username' => trim($request->username), 'password' => trim($request->password)])
        ) {
            $user = Auth::user();
            $success = [];
            $success['token'] = $success['token'] = $user->createToken('ChuanMaPo')->plainTextToken;
            $success['user'] = $user;
            //$user['token'] = $user->createToken('ChuanMaPo')->plainTextToken;
            return HelperController::modelGetAllSuccessfuleMessage($success, 'User login successfully.');
        } else {

            return HelperController::modelUnAuthorizedMessage('Unauthorised');
        }
    }

    public function login_backend(Request $request): JsonResponse
    {
        if (
            Auth::attempt(['phone' => $request->phone, 'password' => trim($request->password)]) ||
            Auth::attempt(['username' => trim($request->username), 'password' => trim($request->password)])
        ) {
            if (Auth::user()->is_admin == 1) {

                $user = Auth::user();
                $success['token'] = $user->createToken('ChuanMaPo')->plainTextToken;

                $success['user'] = $user;
                $success['setting_menu'] = $this->displayDashboardMenu();

                return HelperController::modelGetAllSuccessfuleMessage($success, 'User login successfully.');
            } else {
                Auth::logout();
                //return HelperController::modelUnAuthorizedMessage('Unauthorised');
                return response()->json(['success' => false, 'message' => 'Unauthorised1'], Response::HTTP_UNPROCESSABLE_ENTITY);
            }
        } else {

            //return HelperController::modelUnAuthorizedMessage('Unauthorised');
            return response()->json(['success' => false, 'message' => 'Unauthorised2'], Response::HTTP_UNPROCESSABLE_ENTITY);
        }
    }

    public function logout(Request $request): JsonResponse
    {
        $request->user()->currentAccessToken()->delete();
        return HelperController::modelGetAllSuccessfuleMessage('', 'User logout successfully.');
    }

    public function displayDashboardMenu()
    {
        //        $user = Auth::user();
        $user = User::find(auth()->id());

        //$menus = SettingMenu::get()->toFlatTree();
        $menus = SettingMenu::get()->toTree();
        $user->load(['roles', 'roles.settingMenus']);
        $menuIdArray = [];
        foreach ($user->roles as $role) {
            foreach ($role->settingMenus as $menu) {
                $menuIdArray[] = $menu->id;
            }
        }
        $menuIdArray = array_unique($menuIdArray);
        return $this->checkMenuTree($menuIdArray, $menus);
    }

    protected function checkMenuTree($userMenuIds, $menus)
    {
        $newMenu = [];
        foreach ($menus as $key => $menu) {
            if (in_array($menu->id, $userMenuIds) || Auth::user()->is_superadmin) {
                $newMenu[$key] = [
                    'id' => $menu->id,
                    'english_name' => $menu->english_name,
                    'chinese_name' => $menu->chinese_name,
                    'khmer_name' => $menu->khmer_name,
                    'url_link' => $menu->url_link,
                    //'route_name' => $menu->route_name,
                    'route_path' => $menu->route_path,
                    'url_component' => $menu->url_component,
                    'icons_path' => $menu->icons_path,
                    'isVisible' => $menu->isVisible,
                    'isSystem' => $menu->isSystem,
                    'priority' => $menu->priority,
                    'parent_id' => $menu->parent_id,
                ];
                if ($menu->children->count()) {
                    $newMenu[$key]['children'] = $this->checkMenuTree($userMenuIds, $menu->children);
                }
            }
        }

        return collect($newMenu)->values();
    }

    public function changePassword(Request $request)
    {
        $request->validate([
            'current_password' => [
                'required',
                'min:3'
            ],
            'new_password' => [
                'required',
                'string',
                'min:3',
                //'different:current_password',
            ],
            'confirm_new_password' => ['required', 'same:new_password'],
        ]);

        if (!Hash::check($request->current_password, Auth::user()->password)) {
            return response()->json(['message' => 'Incorrect current password.'], Response::HTTP_UNPROCESSABLE_ENTITY);
        }

        // Update password
        $user = Auth::user();
        $user->password = Hash::make($request->new_password);
        $user->save();

        return response()->json(['message' => 'Password updated successfully.']);
    }
}
