using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000373 RID: 883
	[Serializable]
	public class Message : Object
	{
		// Token: 0x060044C7 RID: 17607 RVA: 0x00153634 File Offset: 0x00151834
		// Note: this type is marked as 'beforefieldinit'.
		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			Message.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "messageId");
			Message.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "text");
			Message.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "sender");
			Message.NativeFieldInfoPtr_endOfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "endOfGroup");
			Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671698);
			Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671699);
			Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671700);
			Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671701);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00153704 File Offset: 0x00151904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155447, RefRangeEnd = 155451, XrefRangeStart = 155446, XrefRangeEnd = 155447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00153740 File Offset: 0x00151940
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 155454, RefRangeEnd = 155460, XrefRangeStart = 155451, XrefRangeEnd = 155454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _endOfGroup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001537B8 File Offset: 0x001519B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155460, XrefRangeEnd = 155462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(TextMessageData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00153804 File Offset: 0x00151A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155462, XrefRangeEnd = 155466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr3) : null;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000218EA File Offset: 0x0001FAEA
		public Message(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x00153844 File Offset: 0x00151A44
		// (set) Token: 0x060044CE RID: 17614 RVA: 0x000218F3 File Offset: 0x0001FAF3
		public unsafe int messageId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId)) = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x0015386C File Offset: 0x00151A6C
		// (set) Token: 0x060044D0 RID: 17616 RVA: 0x0002190E File Offset: 0x0001FB0E
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x00153894 File Offset: 0x00151A94
		// (set) Token: 0x060044D2 RID: 17618 RVA: 0x0002192D File Offset: 0x0001FB2D
		public unsafe Message.ESenderType sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender)) = value;
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x001538BC File Offset: 0x00151ABC
		// (set) Token: 0x060044D4 RID: 17620 RVA: 0x00021948 File Offset: 0x0001FB48
		public unsafe bool endOfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup)) = value;
			}
		}

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeFieldInfoPtr_messageId;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeFieldInfoPtr_endOfGroup;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0;

		// Token: 0x02000969 RID: 2409
		[OriginalName("Assembly-CSharp.dll", "", "ESenderType")]
		public enum ESenderType
		{
			// Token: 0x04008841 RID: 34881
			Player,
			// Token: 0x04008842 RID: 34882
			Other
		}
	}
}
