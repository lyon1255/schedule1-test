using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000288 RID: 648
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x06003007 RID: 12295 RVA: 0x00109254 File Offset: 0x00107454
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversationData()
		{
			Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MSGConversationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr);
			MSGConversationData.NativeFieldInfoPtr_ConversationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ConversationIndex");
			MSGConversationData.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "Read");
			MSGConversationData.NativeFieldInfoPtr_MessageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "MessageHistory");
			MSGConversationData.NativeFieldInfoPtr_ActiveResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ActiveResponses");
			MSGConversationData.NativeFieldInfoPtr_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "IsHidden");
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100668796);
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100668797);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00109310 File Offset: 0x00107510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130803, RefRangeEnd = 130804, XrefRangeStart = 130800, XrefRangeEnd = 130803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData(int conversationIndex, bool read, Il2CppReferenceArray<TextMessageData> messageHistory, Il2CppReferenceArray<TextResponseData> activeResponses, bool isHidden) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref conversationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageHistory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeResponses);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00109398 File Offset: 0x00107598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130813, RefRangeEnd = 130814, XrefRangeStart = 130804, XrefRangeEnd = 130813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000197A4 File Offset: 0x000179A4
		public MSGConversationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x001093D4 File Offset: 0x001075D4
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x000197AD File Offset: 0x000179AD
		public unsafe int ConversationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex)) = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x001093FC File Offset: 0x001075FC
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x000197C8 File Offset: 0x000179C8
		public unsafe bool Read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read)) = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x00109424 File Offset: 0x00107624
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x000197E3 File Offset: 0x000179E3
		public unsafe Il2CppReferenceArray<TextMessageData> MessageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x00109454 File Offset: 0x00107654
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x00019802 File Offset: 0x00017A02
		public unsafe Il2CppReferenceArray<TextResponseData> ActiveResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x00109484 File Offset: 0x00107684
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x00019821 File Offset: 0x00017A21
		public unsafe bool IsHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden)) = value;
			}
		}

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr_ConversationIndex;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr_Read;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr_MessageHistory;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr_ActiveResponses;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeFieldInfoPtr_IsHidden;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
