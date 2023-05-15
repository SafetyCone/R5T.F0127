using System;

using R5T.T0156;


namespace R5T.F0127
{
	/// <summary>
	/// Project and solution descriptor interoperation functionality.
	/// </summary>
	[DocumentationMarker]
	public static class Documentation
	{
        /// <summary>
        /// Visual Studio solutions contain projects, and for a solution to be able to do anything, it needs to contain at least one project.
        /// Visual Studio projects are best edited as part of a solution.
		/// So a solution should have a project, and a project should have a solution.
        /// </summary>
        public static readonly object ProjectHasSolution_SolutionHasProject;
	}
}