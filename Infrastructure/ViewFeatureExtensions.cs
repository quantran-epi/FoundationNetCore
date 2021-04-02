using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationNetCore.Infrastructure
{
    public static class ViewFeatureExtensions
    {
        public static void ViewComponentBeforeViewExecute(
            this DiagnosticListener diagnosticListener,
            ViewComponentContext context,
            IView view)
        {
            // Inlinable fast-path check if Diagnositcs is enabled
            if (diagnosticListener.IsEnabled())
            {
                ViewComponentBeforeViewExecuteImpl(diagnosticListener, context, view);
            }
        }

        private static void ViewComponentBeforeViewExecuteImpl(DiagnosticListener diagnosticListener, ViewComponentContext context, IView view)
        {
            if (diagnosticListener.IsEnabled("Microsoft.AspNetCore.Mvc.ViewComponentBeforeViewExecute"))
            {
                diagnosticListener.Write(
                    "Microsoft.AspNetCore.Mvc.ViewComponentBeforeViewExecute",
                    new
                    {
                        actionDescriptor = context.ViewContext.ActionDescriptor,
                        viewComponentContext = context,
                        view = view
                    });
            }
        }
        public static void ViewComponentAfterViewExecute(
           this DiagnosticListener diagnosticListener,
           ViewComponentContext context,
           IView view)
        {
            // Inlinable fast-path check if Diagnositcs is enabled
            if (diagnosticListener.IsEnabled())
            {
                ViewComponentAfterViewExecuteImpl(diagnosticListener, context, view);
            }
        }

        private static void ViewComponentAfterViewExecuteImpl(DiagnosticListener diagnosticListener, ViewComponentContext context, IView view)
        {
            if (diagnosticListener.IsEnabled("Microsoft.AspNetCore.Mvc.ViewComponentAfterViewExecute"))
            {
                diagnosticListener.Write(
                    "Microsoft.AspNetCore.Mvc.ViewComponentAfterViewExecute",
                    new
                    {
                        actionDescriptor = context.ViewContext.ActionDescriptor,
                        viewComponentContext = context,
                        view = view
                    });
            }
        }

    }
}
