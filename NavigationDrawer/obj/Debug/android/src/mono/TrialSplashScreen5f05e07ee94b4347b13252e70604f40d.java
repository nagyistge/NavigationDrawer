package navigationdrawer.navigationdrawer;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.widget.LinearLayout;
import android.view.ViewGroup;
import android.widget.ImageView;
import java.lang.Thread;
import java.util.Timer;
import java.util.TimerTask;

public class TrialSplashScreen5f05e07ee94b4347b13252e70604f40d extends Activity {
	
	private TimerTask task;
	private Bundle initial_bundle;
	
	protected void onCreate (Bundle bundle)
	{
		super.onCreate (bundle);
		this.initial_bundle = bundle;
		ImageView iv = new ImageView (this);
		iv.setImageResource (R.drawable.monoandroidsplash);
		iv.setScaleType (ImageView.ScaleType.FIT_CENTER);
		ViewGroup.LayoutParams ivparams = new ViewGroup.LayoutParams (ViewGroup.LayoutParams.FILL_PARENT, ViewGroup.LayoutParams.FILL_PARENT);
		setContentView (iv);
		
		task = new TimerTask () {
			@Override
			public void run ()
			{
				finish ();
				Intent intent = new Intent (TrialSplashScreen5f05e07ee94b4347b13252e70604f40d.this, navigationdrawer.MainActivity.class);
				intent.setFlags (Intent.FLAG_ACTIVITY_NEW_TASK);
				startActivity (intent);
			}
		};
		new Timer ().schedule (task, 3000);
	}
}
