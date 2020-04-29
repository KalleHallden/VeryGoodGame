import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:verygoodgame/Controller/authentication.dart';
import 'package:verygoodgame/View/home_page.dart';
import 'package:verygoodgame/View/login.dart';

enum AuthStatus {
  NOT_DETERMINED,
  NOT_LOGGED_IN,
  LOGGED_IN
}
class RootPage extends StatefulWidget {
  RootPage({this.auth});
  final BaseAuth auth;
  @override
  State<StatefulWidget> createState() {
    return _RootPageState();
  }
}


class _RootPageState extends State<RootPage> {
  AuthStatus authStatus = AuthStatus.NOT_DETERMINED;
  String _userId = "";

  void loginCallback() {
    widget.auth.getCurrentUser().then((user) {
      setState(() {
        _userId = user.uid.toString();
      });
    });
    setState(() {
      authStatus = AuthStatus.LOGGED_IN;
    });
  }

  @override
  void initState() {
    super.initState();
    widget.auth.getCurrentUser().then(
      (user) {
        setState(() {
          if (user != null) {
            _userId = user?.uid;
          }
          authStatus =
            user?.uid == null ? AuthStatus.NOT_LOGGED_IN : AuthStatus.LOGGED_IN;
        });
      }
    );
  }

  @override
  Widget build(BuildContext context) {
    switch (authStatus) {
      case AuthStatus.NOT_DETERMINED:
        return buildWaitingScreen();
        break;
      case AuthStatus.NOT_LOGGED_IN:
        return LoginPage(auth: widget.auth, loginCallback: loginCallback,);
        break;
      case AuthStatus.LOGGED_IN:
        if (_userId.length > 0 && _userId != null) {
          return new HomePage();
        }
        break;
      default:
        return buildWaitingScreen();
    }

  }

  Widget buildWaitingScreen() {
    return Scaffold(
      body: Container(child: CircularProgressIndicator(), alignment: Alignment.center,),
    );
  }

}