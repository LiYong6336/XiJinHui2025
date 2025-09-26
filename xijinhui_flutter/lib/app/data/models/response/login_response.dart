class LoginResponse {
  bool? success;
  String? message;
  Data? data;

  LoginResponse({this.success, this.message, this.data});

  LoginResponse.fromJson(Map<String, dynamic> json) {
    success = json['success'];
    message = json['message'];
    data = json['data'] != null ? Data.fromJson(json['data']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['success'] = success;
    data['message'] = message;
    if (this.data != null) {
      data['data'] = this.data!.toJson();
    }
    return data;
  }
}

class Data {
  String? token;
  User? user;

  Data({this.token, this.user});

  Data.fromJson(Map<String, dynamic> json) {
    token = json['token'];
    user = json['user'] != null ? User.fromJson(json['user']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['token'] = token;
    if (user != null) {
      data['user'] = user!.toJson();
    }
    return data;
  }
}

class User {
  int? id;
  String? name;
  String? username;
  String? phone;
  String? email;
  Userinfo? userinfo;

  User(
      {this.id,
      this.name,
      this.username,
      this.phone,
      this.email,
      this.userinfo});

  User.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    name = json['name'];
    username = json['username'];
    phone = json['phone'];
    email = json['email'];
    userinfo =
        json['userinfo'] != null ? Userinfo.fromJson(json['userinfo']) : null;
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['name'] = name;
    data['username'] = username;
    data['phone'] = phone;
    data['email'] = email;
    if (userinfo != null) {
      data['userinfo'] = userinfo!.toJson();
    }
    return data;
  }
}

class Userinfo {
  int? id;
  int? userId;
  String? dateOfBirth;
  String? wechat;
  String? facebook;
  String? avatar;

  Userinfo(
      {this.id,
      this.userId,
      this.dateOfBirth,
      this.wechat,
      this.facebook,
      this.avatar});

  Userinfo.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    userId = json['user_id'];
    dateOfBirth = json['date_of_birth'];
    wechat = json['wechat'];
    facebook = json['facebook'];
    avatar = json['avatar'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['user_id'] = userId;
    data['date_of_birth'] = dateOfBirth;
    data['wechat'] = wechat;
    data['facebook'] = facebook;
    data['avatar'] = avatar;
    return data;
  }
}
