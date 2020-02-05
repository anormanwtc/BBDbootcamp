import java.util.Timer;

public class ScheduleTest {

    public static void main(String[] args) {
    	Timer timer = new Timer();

        // wait 2 seconds (2000 milli-secs) and then start
        timer.schedule(new MyTask("Task1"), 2000);

        for (int i = 0; i < 10; i++) { //schedules tasks 1-10 to happen every 5 seconds
            // wait 1 seconds and then again every 5 seconds forever
            timer.schedule(new MyTask("Task " + i), 1000, 5000);
        } //timer.cancel(); for ending the scheduled loop but that requires the Mytasks related?
    }
}
