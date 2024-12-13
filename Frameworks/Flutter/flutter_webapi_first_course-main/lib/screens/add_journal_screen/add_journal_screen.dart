import 'package:flutter/material.dart';
import 'package:flutter_webapi_first_course/helpers/weekday.dart';
import 'package:flutter_webapi_first_course/models/journal.dart';
import 'package:flutter_webapi_first_course/services/journal_service.dart';

class AddJournalScreen extends StatelessWidget {
  final Journal journal;
  final bool isEditing;

  final TextEditingController _controller = TextEditingController();

  AddJournalScreen({super.key, required this.journal, required this.isEditing});

  @override
  Widget build(BuildContext context) {
    _controller.text = journal.content;
    return Scaffold(
      appBar: AppBar(
        title: Text("${WeekDay(journal.createdAt.weekday).long.toLowerCase()}, "
            "${journal.createdAt.day} / ${journal.createdAt.month} / "
            "${journal.createdAt.year}"),
        actions: [
          IconButton(
            onPressed: () {
              registerJournal(context);
            },
            icon: const Icon(Icons.check),
          ),
        ],
      ),
      body: Padding(
        padding: const EdgeInsets.all(8.0),
        child: TextField(
          keyboardType: TextInputType.multiline,
          controller: _controller,
          style: const TextStyle(fontSize: 24),
          expands: true,
          minLines: null,
          maxLines: null,
        ),
      ),
    );
  }

  registerJournal(BuildContext context) async {
    String content = _controller.text;
    journal.content = content;

    JournalService journalService = JournalService();
    if (isEditing) {
      await journalService.edit(journal.id, journal).then((value) {
        Navigator.pop(context, value);
      });
    } else {
      await journalService.register(journal).then((value) {
        Navigator.pop(context, value);
      });
    }
  }
}
