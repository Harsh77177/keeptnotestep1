
using Keepnote_Step1.Controllers;
using Keepnote_Step1.Models;

namespace keepnote_step1.Repo
{
    public class NoteRepository
    {
        static List<Notes> notes = null;
        public NoteRepository()
        {
            if (notes == null)
            {
                notes = new List<Notes>
                {
                    new Notes(){NoteId=1,NoteTitle="note1",NoteContent="content for note1",CreateDate=DateTime.Parse("01/02/2020")},
                     new Notes(){NoteId=2,NoteTitle="note2",NoteContent="content for note2",CreateDate=DateTime.Parse("01/02/2020")},
                      new Notes(){NoteId=3,NoteTitle="note3",NoteContent="content for note3",CreateDate=DateTime.Parse("01/02/2020")},
                };
            }
        }
        public int AddNotes(Notes note)
        {
            notes.Add(note);
            return 1;
        }
        public int DeleteNotes(int NoteId)
        {
            var obj = notes.Where(x => x.NoteId == NoteId).FirstOrDefault();
            if (obj != null) { notes.Remove(obj); return 1; }
            else return 0;
        }
        public List<Notes> GetNotes()
        {
            return notes;
        }

       

        public Notes GetNoteById(int id)
        {
            return notes.FirstOrDefault(x => x.NoteId == id);
        }
        public int EditNotes(int id, string newContent)
        {
            var objEdit = notes.FirstOrDefault(x => x.NoteId == id);
            if (objEdit != null)
            {
                objEdit.NoteContent = newContent;
                
                return 1;
            }





            else return 0;
        }

       
    }
}