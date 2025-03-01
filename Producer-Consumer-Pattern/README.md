# **Producer-Consumer Pattern**

The **Producer-Consumer pattern** is a common **concurrent programming design pattern** where:

- **Producers** generate data and add it to a shared resource (e.g., a queue).
- **Consumers** take data from the shared resource and process it.
- The shared resource acts as a buffer, preventing **producers from overwhelming consumers** and vice versa.

This pattern is widely used in **multithreading and parallel computing** to decouple the production and consumption of data, ensuring efficient resource management.

---

### **🔹 Why Use Producer-Consumer Pattern?**
✅ **Improves Performance** – Allows producers and consumers to run at different speeds.  
✅ **Thread-Safe Communication** – Avoids race conditions when multiple threads share data.  
✅ **Prevents Resource Exhaustion** – Uses a **bounded queue** to limit memory usage.  
✅ **Decouples Components** – Producers and consumers operate independently.

---

