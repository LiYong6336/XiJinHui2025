<?php

namespace App\Http\Controllers;

use App\Models\GeneratedDeletionCode;
use App\Models\SaleDetail;
use Illuminate\Http\Request;
use Symfony\Component\HttpFoundation\Response;

class HelperController extends Controller
{
    public static  function modelCustomMessage($message)
    {
        return response()->json([
            "success" => true,
            "message" => $message,
        ], Response::HTTP_OK);
    }

    public static  function modelCretedSuccessfuleMessage($modelData, $message = 'Successful Created')
    {
        return response()->json([
            "success" => true,
            "message" => $message,
            "data" => $modelData
        ], Response::HTTP_CREATED);
    }

    public static  function modelGetAllSuccessfuleMessage($modelData, $message = 'Successful Retrieved List')
    {
        return response()->json([
            "success" => true,
            "message" => $message,
            "data" => $modelData
        ], Response::HTTP_OK);
    }
    public static function modelGetSingleSuccessfulMessage($modelData, $message = 'Model Get Single')
    {
        return response()->json([
            "success" => true,
            "message" => $message,
            "data" => $modelData
        ], Response::HTTP_OK);
    }
    public static  function modelUpdateSuccessfulMessage($modelData, $message = 'Successful Updateded')
    {
        return response()->json([
            "success" => true,
            "message" => $message,
            "data" => $modelData
        ], Response::HTTP_OK);
    }
    public static  function modelDeleteSucessfulMessage($modelData, $message = 'Successful Deleted')
    {
        return response()->json([
            "success" => true,
            "message" => $message,
            "data" => $modelData
        ], Response::HTTP_OK);
    }

    public static  function modelOperationErrorMessage($message)
    {
        return response()->json([
            "success" => false,
            "message" => $message,
        ], Response::HTTP_BAD_REQUEST);
    }

    public static  function modelUnAuthorizedMessage($message)
    {
        return response()->json([
            "success" => false,
            "message" => $message,
        ], Response::HTTP_UNAUTHORIZED);
    }

    public static function getFirstLetterFromEnglish($stringEnglish)
    {

        $words = explode(" ", strtoupper($stringEnglish));
        $acronym = "";

        foreach ($words as $w) {
            $acronym .= " " . $w[0];
        }
        return trim($acronym);
    }

    public function generateDeletionCode()
    {
        $code = rand(100000, 999999);

        $generatedCode = GeneratedDeletionCode::where('used_date', null)->orWhere('using_from_db_function', null)->first();
        if ($generatedCode) {
            return self::modelCretedSuccessfuleMessage($generatedCode->code);
        }
        $generatedCode = GeneratedDeletionCode::create([
            'code' => base64_encode($code),
            'user_id' => auth()->user()->id,
            'used_date' => null,
            'using_from_db_function' => null,
        ]);
        return self::modelCretedSuccessfuleMessage($generatedCode->code);
    }
    public function generateDeletionCodeForSaleDetail(Request $request)
    {
        $code = rand(100000, 999999);

        $sale_detail = SaleDetail::find($request->sale_detail_id);

        $generatedCode = GeneratedDeletionCode::where('used_date', null)->where('using_from_db_function', null)->where('sale_detail_json->id', $sale_detail->id)->first();
        if ($generatedCode) {
            return self::modelCretedSuccessfuleMessage($generatedCode->code);
        }
        $generatedCode = GeneratedDeletionCode::create([
            'code' => base64_encode($code),
            'user_id' => auth()->user()->id,
            'used_date' => null,
            'using_from_db_function' => null,
            'sale_detail_json' => $sale_detail,
        ]);
        return self::modelCretedSuccessfuleMessage($generatedCode->code);
    }
}
