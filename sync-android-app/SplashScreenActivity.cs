/**
 * Copyright Red Hat, Inc, and individual contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using FHSDK;
using Android.Content;

namespace syncandroidapp
{
    [Activity(Label = "@string/sync_demo_title", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : AppCompatActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.splash_screen_activity);
            var init = await FHClient.Init();
            if (init)
            {
                StartActivity(new Intent(this, typeof (ListOfItemsActivity)));
                Finish();
            }
        }
    }
}