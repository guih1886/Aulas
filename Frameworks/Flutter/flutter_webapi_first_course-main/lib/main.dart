import 'package:flutter/material.dart';
import 'package:flutter_webapi_first_course/screens/add_journal_screen/add_journal_screen.dart';
import 'package:google_fonts/google_fonts.dart';
import 'models/journal.dart';
import 'screens/home_screen/home_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Simple Journal',
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
          primarySwatch: Colors.red,
          appBarTheme: const AppBarTheme(
              elevation: 0,
              backgroundColor: Colors.red,
              titleTextStyle: TextStyle(color: Colors.white, fontSize: 22),
              iconTheme: IconThemeData(color: Colors.white)),
          textTheme: GoogleFonts.bitterTextTheme()),
      darkTheme: ThemeData.dark(),
      themeMode: ThemeMode.light,
      initialRoute: "home",
      routes: {
        "home": (context) => const HomeScreen(),
      },
      onGenerateRoute: (settings) {
        if (settings.name == "add-journal") {
          Map<String, dynamic> map = settings.arguments as Map<String, dynamic>;
          final Journal journal = map["journal"] as Journal;
          final bool isEditing = map["is_editing"];

          return MaterialPageRoute(builder: (context) {
            return AddJournalScreen(journal: journal, isEditing: isEditing);
          });
        }
        return null;
      },
    );
  }
}
