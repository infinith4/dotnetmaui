using System;
using MemoApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MemoApp.ViewModel
{
    public class MemoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Memo> _memos;
        public ObservableCollection<Memo> Memos
        {
            get => _memos;
            set
            {
                _memos = value;
                OnPropertyChanged();
            }
        }

        public MemoViewModel()
        {
            Memos = new ObservableCollection<Memo>();
        }

        public void AddMemo(Memo memo)
        {
            Memos.Add(memo);
            OnPropertyChanged(nameof(Memos));
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

