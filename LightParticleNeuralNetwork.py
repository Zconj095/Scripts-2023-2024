import numpy as np
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import Axes3D

class LightParticleNeuralNetwork:
    def __init__(self, num_neurons):
        self.num_neurons = num_neurons
        self.weights = np.random.rand(num_neurons, num_neurons)  # Initialize weights
        self.weight_history = []  # To track weight changes

    def process_light_pattern(self, light_pattern):
        """
        Simulates processing of a light pattern. 
        This should contain the logic for updating the network based on light pattern input.

        Args:
            light_pattern (list): A list of light intensity values.
        """
        pattern_input = np.array(light_pattern).reshape(-1, 1)
        self.weights += 0.01 * np.dot(pattern_input, pattern_input.T)  # Dummy weight adjustment

    def induce_neuroplasticity(self, light_patterns, reward_signals):
        """
        Induces neuroplasticity in the network by adjusting weights based on light patterns 
        and associated reward signals.

        Args:
            light_patterns (list of lists): A list of light intensity patterns.
            reward_signals (list): A list of reward values associated with each light pattern.
        """
        for light_pattern, reward in zip(light_patterns, reward_signals):
            self.process_light_pattern(light_pattern)  # Update weights based on particle behavior
            
            # Track weight changes
            self.weight_history.append(self.weights.copy())
            self.weights += reward * 0.01 * (self.weights - np.mean(self.weights))  # Adjust learning rate as needed

    def visualize_neuroplasticity(self):
        """
        Visualizes the network's neuroplasticity by plotting weight changes over time.
        """
        # Convert weight history to numpy array for easier manipulation
        weight_history = np.array(self.weight_history)

        # Create a time array for x-axis
        time = np.arange(weight_history.shape[0])  # Shape: (num_light_patterns, num_neurons, num_neurons)

        # 3D plot of weights over time
        fig = plt.figure()
        ax = fig.add_subplot(111, projection='3d')

        # Plotting weight changes for each neuron
        for i in range(self.num_neurons):
            for j in range(self.num_neurons):
                ax.plot(time, [i] * len(time), weight_history[:, i, j], label=f'Neuron {i+1} to Neuron {j+1}' if j==0 else "", alpha=0.5)

        ax.set_xlabel('Time Steps')
        ax.set_ylabel('Neuron Index')
        ax.set_zlabel('Weight Value')
        ax.set_title('Neuroplasticity Visualization: Weight Changes Over Time')
        ax.legend()

        plt.show()

# Example usage
num_neurons = 5
network = LightParticleNeuralNetwork(num_neurons)

# Simulated light patterns and rewards
light_patterns = [np.random.rand(num_neurons) for _ in range(10)]
reward_signals = np.random.rand(10)  # Random reward signals

# Induce neuroplasticity
network.induce_neuroplasticity(light_patterns, reward_signals)

# Visualize neuroplasticity
network.visualize_neuroplasticity()
