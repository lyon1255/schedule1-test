using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B1 RID: 689
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x06003184 RID: 12676 RVA: 0x0010D9C0 File Offset: 0x0010BBC0
		// Note: this type is marked as 'beforefieldinit'.
		static QuestData()
		{
			Il2CppClassPointerStore<QuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestData>.NativeClassPtr);
			QuestData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "GUID");
			QuestData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "State");
			QuestData.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "IsTracked");
			QuestData.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Title");
			QuestData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Description");
			QuestData.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Expires");
			QuestData.NativeFieldInfoPtr_ExpiryDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "ExpiryDate");
			QuestData.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Entries");
			QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestData>.NativeClassPtr, 100668839);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131037, RefRangeEnd = 131040, XrefRangeStart = 131031, XrefRangeEnd = 131037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x0001A7C1 File Offset: 0x000189C1
		public QuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0010DB68 File Offset: 0x0010BD68
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x0001A7CA File Offset: 0x000189CA
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x0010DB90 File Offset: 0x0010BD90
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x0001A7E9 File Offset: 0x000189E9
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x0010DBB8 File Offset: 0x0010BDB8
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x0001A804 File Offset: 0x00018A04
		public unsafe bool IsTracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked)) = value;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x0010DBE0 File Offset: 0x0010BDE0
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x0001A81F File Offset: 0x00018A1F
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x0010DC08 File Offset: 0x0010BE08
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x0001A83E File Offset: 0x00018A3E
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x0010DC30 File Offset: 0x0010BE30
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x0001A85D File Offset: 0x00018A5D
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x0010DC58 File Offset: 0x0010BE58
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x0001A878 File Offset: 0x00018A78
		public unsafe GameDateTimeData ExpiryDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x0010DC88 File Offset: 0x0010BE88
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x0001A897 File Offset: 0x00018A97
		public unsafe Il2CppReferenceArray<QuestEntryData> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntryData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr_IsTracked;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryDate;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0;
	}
}
