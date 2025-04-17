using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B2 RID: 690
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x06003197 RID: 12695 RVA: 0x0010DCB8 File Offset: 0x0010BEB8
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntryData()
		{
			Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr);
			QuestEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "Name");
			QuestEntryData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "State");
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100668840);
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100668841);
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x0010DD38 File Offset: 0x0010BF38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130604, RefRangeEnd = 130609, XrefRangeStart = 130604, XrefRangeEnd = 130609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData(string name, EQuestState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x0010DD94 File Offset: 0x0010BF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130409, RefRangeEnd = 130410, XrefRangeStart = 130409, XrefRangeEnd = 130410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0001A8B6 File Offset: 0x00018AB6
		public QuestEntryData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x0010DDD0 File Offset: 0x0010BFD0
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x0001A8BF File Offset: 0x00018ABF
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x0010DDF8 File Offset: 0x0010BFF8
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x0001A8DE File Offset: 0x00018ADE
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
