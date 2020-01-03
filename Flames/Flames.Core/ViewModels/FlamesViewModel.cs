using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace Flames.Core.ViewModels
{
    public class FlamesViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public FlamesViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        


             bool showFlamesResult = false;

        public bool ShowFlamesResult
        {
            get { return showFlamesResult; }
            set
            {
                if (SetProperty(ref showFlamesResult, value))
                    RaisePropertyChanged(() => ShowFlamesResult);
            }
        }


        string flamesResult = string.Empty;

        public string FlamesResult
        {
            get { return flamesResult; }
            set
            {
                if (SetProperty(ref flamesResult, value))
                    RaisePropertyChanged(() => FlamesResult);
            }
        }

        string firstName = string.Empty;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (SetProperty(ref firstName, value))
                    RaisePropertyChanged(() => FirstName);
            }
        }


        string secondName = string.Empty;

        public string SecondName
        {
            get { return secondName; }
            set
            {
                if (SetProperty(ref secondName, value))
                    RaisePropertyChanged(() => SecondName);
            }
        }

        // public string Hello => $"Hello {YourNickname}";
        
             public ICommand ClosePopup => new Command(CloseFlamesPopup);
        private void  CloseFlamesPopup()
        {
            ShowFlamesResult = false;
            FirstName = string.Empty;
            SecondName = string.Empty;
        }
        public ICommand FindFlames => new Command(DoFlames);
        private void DoFlames()
        {

              if(FirstName==string.Empty)
            {

            }
            else if(SecondName==string.Empty)
            {

            }
            else
            {
            int TotalLetters=FirstName.Length+SecondName.Length;
            int FinalLetters;
            string First=string.Empty;
             string Second=string.Empty;
             string Match=string.Empty;

                for (int i = 0; i <= FirstName.Length - 1; ++i)
                {
                    First = FirstName.Substring(i, 1);
                    for (int j = 0; j <= SecondName.Length - 1; ++j)
                    {
                        Second = SecondName.Substring(j, 1);
                        if (First == Second)
                        {
                            Match = Match + "1";
                        }
                    }
                }
                FinalLetters=Match.Length;
                int FinalResult=TotalLetters-FinalLetters;
                if(FinalResult%6==1)
                {
                    FlamesResult = "Friends For Life";
                }
               else if (FinalResult % 6 == 2)
                {
                    FlamesResult = " Congratulations Love Birds ";
                }
               else if (FinalResult % 6 == 3)
                {
                    FlamesResult = "Affair";
                }
               else if (FinalResult % 6 == 4)
                {
                    FlamesResult = "Happy Married life";
                }
               else if (FinalResult % 6 == 5)
                {
                    FlamesResult = "Born as Enemies";
                }
               else if (FinalResult % 6 == 0)
                {
                    FlamesResult = "Sweet";
                }
                ShowFlamesResult = true;
            }
           
              

           

           
        }
    }
}


