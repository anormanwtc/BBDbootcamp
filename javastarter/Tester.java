import com.vogella.javaintro.base.MyStaticExample;
import com.vogella.javaintro.base.MyExtentionClass;

public class Tester {

    public static void main(String[] args) {
        System.out.println(MyStaticExample.stat);
        MyStaticExample.statMethod();
        MyExtentionClass test = new MyExtentionClass();
        test.hello();

    }
}