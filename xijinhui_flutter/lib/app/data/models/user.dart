class User {
  int? id;
  String? name;
  String? username;
  String? email;
  String? userLocale;
  String? phone;

  User(
      {this.id,
      this.name,
      this.username,
      this.email,
      this.userLocale,
      this.phone});

  User.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    name = json['name'];
    username = json['username'];
    email = json['email'];
    userLocale = json['user_locale'];
    phone = json['phone'];
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['name'] = name;
    data['username'] = username;
    data['email'] = email;
    data['user_locale'] = userLocale;
    data['phone'] = phone;
    return data;
  }
}
