using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000181 RID: 385
	[Serializable]
	public class QuestCondition : Object
	{
		// Token: 0x06001EAB RID: 7851 RVA: 0x000CFD9C File Offset: 0x000CDF9C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestCondition()
		{
			Il2CppClassPointerStore<QuestCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "QuestCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr);
			QuestCondition.NativeFieldInfoPtr_CheckQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestState");
			QuestCondition.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestName");
			QuestCondition.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestState");
			QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestEntryState");
			QuestCondition.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryIndex");
			QuestCondition.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryState");
			QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666765);
			QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666766);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000CFE6C File Offset: 0x000CE06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107332, XrefRangeEnd = 107348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000CFEA8 File Offset: 0x000CE0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107348, XrefRangeEnd = 107353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestCondition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0001148A File Offset: 0x0000F68A
		public QuestCondition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000CFEE4 File Offset: 0x000CE0E4
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00011493 File Offset: 0x0000F693
		public unsafe bool CheckQuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState)) = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000CFF0C File Offset: 0x000CE10C
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000114AE File Offset: 0x0000F6AE
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000CFF34 File Offset: 0x000CE134
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000114CD File Offset: 0x0000F6CD
		public unsafe EQuestState QuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000CFF5C File Offset: 0x000CE15C
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x000114E8 File Offset: 0x0000F6E8
		public unsafe bool CheckQuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState)) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x000CFF84 File Offset: 0x000CE184
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00011503 File Offset: 0x0000F703
		public unsafe int QuestEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000CFFAC File Offset: 0x000CE1AC
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x0001151E File Offset: 0x0000F71E
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestState;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestEntryState;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
