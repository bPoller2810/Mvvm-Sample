namespace BasicMvvm
{
    public class MyDataViewModel : BaseViewModel
    {


        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                {
                    return;
                }
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private string _content;
        public string Content
        {
            get => _content;
            set
            {
                if (_content == value)
                {
                    return;
                }

                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        public MyDataViewModel(string title, string content)
        {
            Title = title;
            Content = content;
        }

    }
}
