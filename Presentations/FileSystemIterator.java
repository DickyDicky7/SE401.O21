// Lớp File
class File {
    private String name;

    public File(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
}

// Lớp Directory
class Directory {
    private List<File> files;
    private List<Directory> subDirectories;

    public Directory(String name) {
        this.files = new ArrayList<>();
        this.subDirectories = new ArrayList<>();
    }

    public void addFile(File file) {
        files.add(file);
    }

    public void addSubDirectory(Directory directory) {
        subDirectories.add(directory);
    }

    public Iterator<File> iterator() {
        return new FileSystemIterator(this);
    }
}

// Lớp FileSystemIterator
interface FileSystemIterator {
    boolean hasNext();
    File next();
}

// Lớp ConcreteFileSystemIterator
class ConcreteFileSystemIterator implements FileSystemIterator {
    private Directory directory;
    private int currentIndex;

    public ConcreteFileSystemIterator(Directory directory) {
        this.directory = directory;
        currentIndex = 0;
    }

    @Override
    public boolean hasNext() {
        return currentIndex < directory.size();
    }

    @Override
    public File next() {
        return directory.get(currentIndex++);
    }
}

// Lớp Main
public class Main {
    public static void main(String[] args) {
        Directory rootDirectory = new Directory("root");
        Directory subDirectory1 = new Directory("sub1");
        Directory subDirectory2 = new Directory("sub2");
        rootDirectory.addSubDirectory(subDirectory1);
        rootDirectory.addSubDirectory(subDirectory2);

        File file1 = new File("file1.txt");
        File file2 = new File("file2.txt");
        subDirectory1.addFile(file1);
        subDirectory2.addFile(file2);

        FileSystemIterator iterator = rootDirectory.iterator();
        while (iterator.hasNext()) {
            File file = iterator.next();
            System.out.println(file.getName());
        }
    }
}
