<?php

namespace App\Http\Controllers;

use App\Models\Role;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class RoleController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $role = auth()->user()->roles()->first();
        $roles = Role::with('settingMenus')->where('id', '>=', $role->id)->get();
        return HelperController::modelGetAllSuccessfuleMessage($roles);
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $role = Role::create([
            'name' => $request->name,
            'guard_name' => 'web',
        ]);

        $role->settingMenus()->sync($request->menu_ids);

        return HelperController::modelCretedSuccessfuleMessage($role);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Role $role)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Role $role)
    {
        $role->name = $request->name;
        if (auth()->user()->roles()->first()->id == $role->id) {
            return response([
                'message' => 'You can not update your own role'
            ], Response::HTTP_UNPROCESSABLE_ENTITY);
        }
        $role->settingMenus()->sync($request->menu_ids);

        return HelperController::modelUpdateSuccessfulMessage($role);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Role $role)
    {
        $role->delete();
        return response('', Response::HTTP_NO_CONTENT);
    }
}
