using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B0 RID: 688
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		// Token: 0x0600317F RID: 12671 RVA: 0x0010D868 File Offset: 0x0010BA68
		// Note: this type is marked as 'beforefieldinit'.
		static DeaddropQuestData()
		{
			Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeaddropQuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr);
			DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, "DeaddropGUID");
			DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, 100668838);
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0010D8C0 File Offset: 0x0010BAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131030, RefRangeEnd = 131031, XrefRangeStart = 131028, XrefRangeEnd = 131030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string deaddropGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deaddropGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0001A799 File Offset: 0x00018999
		public DeaddropQuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x0010D998 File Offset: 0x0010BB98
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0001A7A2 File Offset: 0x000189A2
		public unsafe string DeaddropGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropGUID;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0;
	}
}
