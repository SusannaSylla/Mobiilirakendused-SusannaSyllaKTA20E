using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView AnswerTextView;
        EditText firstNumberEditText;
        EditText secondNumberEditText;
        Button addButton;
        Button subtractButton;
        Button multiplierButton;
        Button divideButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            firstNumberEditText = FindViewById<EditText>(Resource.Id.editText1);
            secondNumberEditText = FindViewById<EditText>(Resource.Id.editText2);
            addButton = FindViewById<Button>(Resource.Id.addButton);
            subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
            multiplierButton = FindViewById<Button>(Resource.Id.multiplierButton);
            divideButton = FindViewById<Button>(Resource.Id.divideButton);
            AnswerTextView = FindViewById<TextView>(Resource.Id.answerTextView);
            addButton.Click += AddButton_Click;
            subtractButton.Click += SubtractButton_Click;
            multiplierButton.Click += MultiplierButton_Click;
            divideButton.Click += DivideButton_Click;

        }

        private void DivideButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber / secondNumber;

            AnswerTextView.Text = answer.ToString();
        }

        private void MultiplierButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber * secondNumber;

            AnswerTextView.Text = answer.ToString();
        }

        private void SubtractButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber - secondNumber;

            AnswerTextView.Text = answer.ToString();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber + secondNumber;

            AnswerTextView.Text = answer.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}