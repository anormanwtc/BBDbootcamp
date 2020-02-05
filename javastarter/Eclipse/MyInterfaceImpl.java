
public class MyInterfaceImpl implements MyInterface {

    @Override
    public void test() {
    }

    @Override
    public void write(String s) {

        System.out.println(s);
    }

    public static void main(String[] args) {
        MyInterfaceImpl impl = new MyInterfaceImpl();
        System.out.println(impl.reserveString("Lars Vogel"));
        impl.write("hello");
    }
}