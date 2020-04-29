import 'package:flutter/material.dart';
import 'package:verygoodgame/Controller/authentication.dart';

class LoginPage extends StatefulWidget {

  LoginPage({this.auth, this.loginCallback});
  final BaseAuth auth;
  final VoidCallback loginCallback;
  @override
  State<StatefulWidget> createState() {
    return _LoginPageState();
  }
}


class _LoginPageState extends State<LoginPage> {

  String email;
  String password;
  TextEditingController emailController = new TextEditingController();
  TextEditingController passwordController = new TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        padding: EdgeInsets.only(top: 100, left: 20, right: 20),
        child: Column(
          children: <Widget> [
            TextField(
              controller: emailController,
            ),
            TextField(
              controller: passwordController,
            ),
            FlatButton(
              child: Text("Login"),
              onPressed: () {
                email = emailController.text;
                password = passwordController.text;
                if (email.length > 0 && password.length > 0) {
                  validateAndSubmit();
                }
              }
            )
          ]
        ),
      ),
    );
  }

  void validateAndSubmit() async {
    String userId = await widget.auth.signUp(email, password);
    if (userId.length > 0 && userId != null) {
      widget.loginCallback();
    }
  }

}