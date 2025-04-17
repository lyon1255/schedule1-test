using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000377 RID: 887
	public class SendableMessage : Object
	{
		// Token: 0x060045A4 RID: 17828 RVA: 0x0015716C File Offset: 0x0015536C
		// Note: this type is marked as 'beforefieldinit'.
		static SendableMessage()
		{
			Il2CppClassPointerStore<SendableMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "SendableMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr);
			SendableMessage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "Text");
			SendableMessage.NativeFieldInfoPtr_ShouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ShouldShowCheck");
			SendableMessage.NativeFieldInfoPtr_IsValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "IsValidCheck");
			SendableMessage.NativeFieldInfoPtr_onSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSelected");
			SendableMessage.NativeFieldInfoPtr_onSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSent");
			SendableMessage.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "conversation");
			SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "disableDefaultSendBehaviour");
			SendableMessage.NativeFieldInfoPtr_sentIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "sentIDs");
			SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671862);
			SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671863);
			SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671864);
			SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100671865);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0015728C File Offset: 0x0015548C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157503, XrefRangeEnd = 157513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage(string text, MSGConversation conversation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x001572EC File Offset: 0x001554EC
		[CallerCount(0)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00157334 File Offset: 0x00155534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157513, XrefRangeEnd = 157517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00157398 File Offset: 0x00155598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157517, XrefRangeEnd = 157533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(bool network, int id = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00021E38 File Offset: 0x00020038
		public SendableMessage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x001573F0 File Offset: 0x001555F0
		// (set) Token: 0x060045AB RID: 17835 RVA: 0x00021E41 File Offset: 0x00020041
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x00157418 File Offset: 0x00155618
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x00021E60 File Offset: 0x00020060
		public unsafe SendableMessage.BoolCheck ShouldShowCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.BoolCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x00157448 File Offset: 0x00155648
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00021E7F File Offset: 0x0002007F
		public unsafe SendableMessage.ValidityCheck IsValidCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.ValidityCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00157478 File Offset: 0x00155678
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00021E9E File Offset: 0x0002009E
		public unsafe Action onSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x001574A8 File Offset: 0x001556A8
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x00021EBD File Offset: 0x000200BD
		public unsafe Action onSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001574D8 File Offset: 0x001556D8
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x00021EDC File Offset: 0x000200DC
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x00157508 File Offset: 0x00155708
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x00021EFB File Offset: 0x000200FB
		public unsafe bool disableDefaultSendBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour)) = value;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x00157530 File Offset: 0x00155730
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x00021F16 File Offset: 0x00020116
		public unsafe List<int> sentIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeFieldInfoPtr_ShouldShowCheck;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeFieldInfoPtr_IsValidCheck;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeFieldInfoPtr_onSelected;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_onSent;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultSendBehaviour;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeFieldInfoPtr_sentIDs;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x02000972 RID: 2418
		public sealed class BoolCheck : MulticastDelegate
		{
			// Token: 0x0600C991 RID: 51601 RVA: 0x0030C920 File Offset: 0x0030AB20
			// Note: this type is marked as 'beforefieldinit'.
			static BoolCheck()
			{
				Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "BoolCheck");
				SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671866);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671867);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671868);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100671869);
			}

			// Token: 0x0600C992 RID: 51602 RVA: 0x0030C994 File Offset: 0x0030AB94
			[CallerCount(480)]
			[CachedScanResults(RefRangeStart = 135093, RefRangeEnd = 135573, XrefRangeStart = 135093, XrefRangeEnd = 135573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C993 RID: 51603 RVA: 0x0030C9F0 File Offset: 0x0030ABF0
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C994 RID: 51604 RVA: 0x0030CA40 File Offset: 0x0030AC40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C995 RID: 51605 RVA: 0x0030CAB4 File Offset: 0x0030ACB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C996 RID: 51606 RVA: 0x00062089 File Offset: 0x00060289
			public BoolCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C997 RID: 51607 RVA: 0x00062092 File Offset: 0x00060292
			public static implicit operator SendableMessage.BoolCheck(Func<SendableMessage, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SendableMessage.BoolCheck>(A_0);
			}

			// Token: 0x0600C998 RID: 51608 RVA: 0x0006209A File Offset: 0x0006029A
			public static SendableMessage.BoolCheck operator +(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SendableMessage.BoolCheck>();
			}

			// Token: 0x0600C999 RID: 51609 RVA: 0x000620A8 File Offset: 0x000602A8
			public static SendableMessage.BoolCheck operator -(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<SendableMessage.BoolCheck>();
				}
				return result;
			}

			// Token: 0x0400886A RID: 34922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400886B RID: 34923
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0;

			// Token: 0x0400886C RID: 34924
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0;

			// Token: 0x0400886D RID: 34925
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x02000973 RID: 2419
		public sealed class ValidityCheck : MulticastDelegate
		{
			// Token: 0x0600C99A RID: 51610 RVA: 0x0030CB04 File Offset: 0x0030AD04
			// Note: this type is marked as 'beforefieldinit'.
			static ValidityCheck()
			{
				Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ValidityCheck");
				SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671870);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671871);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671872);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100671873);
			}

			// Token: 0x0600C99B RID: 51611 RVA: 0x0030CB78 File Offset: 0x0030AD78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 157497, RefRangeEnd = 157500, XrefRangeStart = 157488, XrefRangeEnd = 157497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidityCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C99C RID: 51612 RVA: 0x0030CBD4 File Offset: 0x0030ADD4
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message, out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600C99D RID: 51613 RVA: 0x0030CC3C File Offset: 0x0030AE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157500, XrefRangeEnd = 157501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, out string invalidReason, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600C99E RID: 51614 RVA: 0x0030CCCC File Offset: 0x0030AECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157501, XrefRangeEnd = 157503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600C99F RID: 51615 RVA: 0x000620B9 File Offset: 0x000602B9
			public ValidityCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400886E RID: 34926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400886F RID: 34927
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0;

			// Token: 0x04008870 RID: 34928
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0;

			// Token: 0x04008871 RID: 34929
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
