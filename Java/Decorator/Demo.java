interface Component {
    float calculatePrice();
}

class MilkTea implements Component {
    @Override
    public float calculatePrice() {
        return 20000;
    }
}

class BaseTopping implements Component {
    private final Component wrappee;

    public BaseTopping(Component wrappee) {
        this.wrappee = wrappee;
    }

    @Override
    public float calculatePrice() {
        return this.wrappee.calculatePrice();
    }
}

class MilkForm extends BaseTopping {
    public MilkForm(Component wrappee) {
        super(wrappee);
    }

    @Override
    public float calculatePrice() {
        return super.calculatePrice() + 15000;
    }
}

class Bubble extends BaseTopping {
    public Bubble(Component wrappee) {
        super(wrappee);
    }
    @Override
    public float calculatePrice() {
        return super.calculatePrice() + 5000;
    }
}

public class Demo {
    //this is client code
    public static void main(String[] args) {
        //Order a milk tea
        Component c = new MilkTea();

        //With foam
        c = new MilkForm(c);

        //You like foam, so you order extra foam
        c = new MilkForm(c);



        System.out.println("The price is: " + c.calculatePrice());
    }
}