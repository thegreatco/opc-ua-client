﻿// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Workstation.ServiceModel.Ua
{
    public static class SubscriptionServiceSet
    {
        /// <summary>
        /// Creates a Subscription.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="CreateSubscriptionRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="CreateSubscriptionResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.2/">OPC UA specification Part 4: Services, 5.13.2</seealso>
        public static async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(this IRequestChannel channel, CreateSubscriptionRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (CreateSubscriptionResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Modifies a Subscription.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="ModifySubscriptionRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="ModifySubscriptionResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.3/">OPC UA specification Part 4: Services, 5.13.3</seealso>
        public static async Task<ModifySubscriptionResponse> ModifySubscriptionAsync(this IRequestChannel channel, ModifySubscriptionRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (ModifySubscriptionResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Enables sending of Notifications on one or more Subscriptions.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="SetPublishingModeRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="SetPublishingModeResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.4/">OPC UA specification Part 4: Services, 5.13.4</seealso>
        public static async Task<SetPublishingModeResponse> SetPublishingModeAsync(this IRequestChannel channel, SetPublishingModeRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (SetPublishingModeResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Requests the Server to return a NotificationMessage or a keep-alive Message.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="PublishRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="PublishResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.5/">OPC UA specification Part 4: Services, 5.13.5</seealso>
        internal static async Task<PublishResponse> PublishAsync(this IRequestChannel channel, PublishRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (PublishResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Requests the Server to republish a NotificationMessage from its retransmission queue.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="RepublishRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="RepublishResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.6/">OPC UA specification Part 4: Services, 5.13.6</seealso>
        internal static async Task<RepublishResponse> RepublishAsync(this IRequestChannel channel, RepublishRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (RepublishResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Transfers a Subscription and its MonitoredItems from one Session to another.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="TransferSubscriptionsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="TransferSubscriptionsResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.7/">OPC UA specification Part 4: Services, 5.13.7</seealso>
        public static async Task<TransferSubscriptionsResponse> TransferSubscriptionsAsync(this IRequestChannel channel, TransferSubscriptionsRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (TransferSubscriptionsResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes one or more Subscriptions.
        /// </summary>
        /// <param name="channel">A instance of <see cref="IRequestChannel"/>.</param>
        /// <param name="request">A <see cref="DeleteSubscriptionsRequest"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that returns a <see cref="DeleteSubscriptionsResponse"/>.</returns>
        /// <seealso href="https://reference.opcfoundation.org/v104/Core/docs/Part4/5.13.8/">OPC UA specification Part 4: Services, 5.13.8</seealso>
        public static async Task<DeleteSubscriptionsResponse> DeleteSubscriptionsAsync(this IRequestChannel channel, DeleteSubscriptionsRequest request, CancellationToken token = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return (DeleteSubscriptionsResponse)await channel.RequestAsync(request, token).ConfigureAwait(false);
        }
    }
}
