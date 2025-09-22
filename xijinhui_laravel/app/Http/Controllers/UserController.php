<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreUserRequest;
use App\Http\Requests\UpdateUserRequest;
use App\Models\User;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class UserController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        if (auth()->user()->is_superadmin) {
            $users = User::with('roles')->get();
        } else {
            $users = User::where('is_superadmin', false)->with('roles')->get();
        }

        return HelperController::modelGetAllSuccessfuleMessage(
            $users
        );
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(StoreUserRequest $request)
    {
        $user = User::create(array_merge($request->validated(), [
            'name' => $request->username,
            'email' => $request->username . '@email.com',
            'password' => bcrypt($request->get('password', 123456))
        ]));
        if ($request->role_id) {
            $user->roles()->sync([$request->role_id]);
        }
        return HelperController::modelGetSingleSuccessfulMessage($user->refresh()->load('roles'));
    }

    /**
     * Display the specified resource.
     */
    public function show(User $user)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(User $user)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(UpdateUserRequest $request, User $user)
    {
        $validated = $request->validated();
        unset($validated['password']);
        $user->update(array_merge($validated, [
            'name' => $request->username,
            'email' => $request->username . '@email.com',
            'is_admin' => $request->boolean('is_admin'),
        ]));
        if ($request->password) {
            $user->password = bcrypt($request->password);
            $user->save();
        }
        if ($request->role_id) {
            $user->roles()->sync([$request->role_id]);
        }
        return HelperController::modelGetSingleSuccessfulMessage($user->refresh()->load('roles'));
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(User $user)
    {
        $user->delete();
        return response('', Response::HTTP_NO_CONTENT);
    }
}
