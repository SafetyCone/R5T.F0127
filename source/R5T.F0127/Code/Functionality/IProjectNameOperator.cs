using System;

using R5T.T0132;
using R5T.T0187;


namespace R5T.F0127
{
    /// <summary>
    /// Strongly-typed functionality for interoperating between library, repository, solution, and project descriptor types.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IProjectNameOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Get the default project name for a solution name.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="Documentation.ProjectHasSolution_SolutionHasProject" path="/summary"/>
        /// </remarks>
        public IProjectName Get_DefaultProjectName(ISolutionName solutionName)
        {
            // Use the same name.
            var projectName = solutionName.Value;

            var output = Instances.ProjectNameParser.Ensure_IsValid(projectName);
            return output;
        }
    }
}
