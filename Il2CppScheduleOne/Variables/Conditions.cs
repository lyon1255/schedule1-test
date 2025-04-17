using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200017F RID: 383
	[Serializable]
	public class Conditions : Object
	{
		// Token: 0x06001E9C RID: 7836 RVA: 0x000CFA34 File Offset: 0x000CDC34
		// Note: this type is marked as 'beforefieldinit'.
		static Conditions()
		{
			Il2CppClassPointerStore<Conditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Conditions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conditions>.NativeClassPtr);
			Conditions.NativeFieldInfoPtr_EvaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "EvaluationType");
			Conditions.NativeFieldInfoPtr_ConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "ConditionList");
			Conditions.NativeFieldInfoPtr_QuestConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "QuestConditionList");
			Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666760);
			Conditions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666761);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107314, RefRangeEnd = 107316, XrefRangeStart = 107303, XrefRangeEnd = 107314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000CFB04 File Offset: 0x000CDD04
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conditions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conditions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0001141F File Offset: 0x0000F61F
		public Conditions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000CFB40 File Offset: 0x000CDD40
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00011428 File Offset: 0x0000F628
		public unsafe Conditions.EEvaluationType EvaluationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000CFB68 File Offset: 0x000CDD68
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00011443 File Offset: 0x0000F643
		public unsafe Il2CppReferenceArray<Condition> ConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Condition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000CFB98 File Offset: 0x000CDD98
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00011462 File Offset: 0x0000F662
		public unsafe Il2CppReferenceArray<QuestCondition> QuestConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_EvaluationType;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_ConditionList;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_QuestConditionList;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008AF RID: 2223
		[OriginalName("Assembly-CSharp.dll", "", "EEvaluationType")]
		public enum EEvaluationType
		{
			// Token: 0x04008435 RID: 33845
			And,
			// Token: 0x04008436 RID: 33846
			Or
		}
	}
}
