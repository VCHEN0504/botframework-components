﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace ITSMSkill.TeamsChannels.Invoke
{
    using System;
    using System.Collections.Generic;
    using ITSMSkill.Dialogs.Teams.TicketTaskModule;
    using ITSMSkill.Extensions.Teams;
    using Microsoft.Bot.Schema.Teams;

    /// <summary>
    /// ITSMTeamsInvokeActivityhandler Factory Class for TaskModules
    /// </summary>
    public class ITSMTeamsInvokeActivityHandlerFactory : TeamsInvokeActivityHandlerFactory
    {
        public ITSMTeamsInvokeActivityHandlerFactory(IServiceProvider serviceProvider)
        {
            this.TaskModuleFetchSubmitMap = new Dictionary<string, Func<ITeamsTaskModuleHandler<TaskModuleResponse>>>
            {
                {
                    $"{TeamsFlowType.CreateTicket_Form}",
                    () => new CreateTicketTeamsImplementation(serviceProvider)
                },

                // TODO Already Added: Update/Delete Teams TaskModule in another PR
            };
        }
    }
}