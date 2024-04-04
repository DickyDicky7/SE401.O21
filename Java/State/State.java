interface DocumentState {
    void open();
    void close();
    void save();
}

class DraftState implements DocumentState {
    @Override
    public void open() {
        System.out.println("Document is already in draft state.");
    }

    @Override
    public void close() {
        System.out.println("Closing the document.");
    }

    @Override
    public void save() {
        System.out.println("Saving the document as draft.");
    }
}

class PublishedState implements DocumentState {
    @Override
    public void open() {
        System.out.println("Opening the published document.");
    }

    @Override
    public void close() {
        System.out.println("Closing the document.");
    }

    @Override
    public void save() {
        System.out.println("Saving the document as published version.");
    }
}

class Document {
    private DocumentState state;

    public Document() {
        this.state = new DraftState();
    }

    public void setState(DocumentState state) {
        this.state = state;
    }

    public void open() {
        state.open();
    }

    public void close() {
        state.close();
    }

    public void save() {
        state.save();
    }
}

public class StateExample {
    public static void main(String[] args) {
        Document document = new Document();

        // Mở Document
        document.open();

        // Lưu Document
        document.save();

        // Đóng Document
        document.close();

        // Chuyển trạng thái Document thành Published
        document.setState(new PublishedState());

        // Mở Document đã được xuất bản
        document.open();

        // Lưu Document đã được xuất bản
        document.save();

        // Đóng Document đã được xuất bản
        document.close();
    }
}