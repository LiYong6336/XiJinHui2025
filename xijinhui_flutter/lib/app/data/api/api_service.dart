import 'package:chuanmapo_flutter/app/data/api/api_constants.dart';
import 'package:chuanmapo_flutter/app/data/shared/utils/helpers.dart';
import 'package:dio/dio.dart';
import 'package:shared_preferences/shared_preferences.dart';

class ApiService {
  static final _options = BaseOptions(
    baseUrl: ApiConstants.baseUrl,
    connectTimeout: const Duration(seconds: ApiConstants.connectionTimeout),
    receiveTimeout: const Duration(seconds: ApiConstants.receiveTimeout),
    responseType: ResponseType.json,
  );

  // dio instance
  // final Dio _dio = Dio(_options)..interceptors.add(authInterceptor(_options));

  final Dio _dio = Dio(_options)
    ..interceptors.add(InterceptorsWrapper(onRequest: (options, handler) async {
      SharedPreferences prefs = await SharedPreferences.getInstance();
      // Do something before request is sent
      options.headers.putIfAbsent('Accept', () => 'application/json');
      options.headers.putIfAbsent(
          'Authorization', () => 'Bearer ${prefs.getString('token')}');
      options.baseUrl = getApiUrl();

      return handler.next(options); //continue
    }, onResponse: (response, handler) async {
      // Do something with response data
      return handler.next(response); // continue
    }, onError: (DioException e, handler) async {
      // Do something with response error
      return handler.next(e); //continue
    }));

  // GET request
  Future<Response> get(
    String url, {
    Map<String, dynamic>? queryParameters,
    Options? options,
    CancelToken? cancelToken,
    ProgressCallback? onReceiveProgress,
  }) async {
    try {
      print('GET: $url');
      final Response response = await _dio.get(
        url,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onReceiveProgress: onReceiveProgress,
      );
      print('GET $url Response: $response');
      return response;
    } catch (e) {
      print('GET $url Error: $e');
      rethrow;
    }
  }

  // POST request
  Future<Response> post(
    String url, {
    dynamic data,
    Map<String, dynamic>? queryParameters,
    Options? options,
    CancelToken? cancelToken,
    ProgressCallback? onSendProgress,
    ProgressCallback? onReceiveProgress,
  }) async {
    try {
      print('POST: ${ApiConstants.baseUrl}/$url Request: $data');
      final Response response = await _dio.post(
        url,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onSendProgress: onSendProgress,
        onReceiveProgress: onReceiveProgress,
      );
      print('POST: $url, Response: $response');
      return response;
    } catch (e) {
      print('POST $url Error: $e');
      rethrow;
    }
  }

  // PUT request
  Future<Response> put(
    String url, {
    dynamic data,
    Map<String, dynamic>? queryParameters,
    Options? options,
    CancelToken? cancelToken,
    ProgressCallback? onSendProgress,
    ProgressCallback? onReceiveProgress,
  }) async {
    try {
      print('PUT: $url');
      final Response response = await _dio.put(
        url,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
        onSendProgress: onSendProgress,
        onReceiveProgress: onReceiveProgress,
      );
      print('PUT: $url, Response: $response');
      return response;
    } catch (e) {
      print('PUT $url Error: $e');
      rethrow;
    }
  }

  // DELETE request
  Future<Response> delete(
    String url, {
    dynamic data,
    Map<String, dynamic>? queryParameters,
    Options? options,
    CancelToken? cancelToken,
    ProgressCallback? onSendProgress,
    ProgressCallback? onReceiveProgress,
  }) async {
    try {
      print('DELETE: $url');
      final Response response = await _dio.delete(
        url,
        data: data,
        queryParameters: queryParameters,
        options: options,
        cancelToken: cancelToken,
      );
      print('DELETE: $url, Response: $response');
      return response;
    } catch (e) {
      print('DELETE $url Error: $e');
      rethrow;
    }
  }
}
