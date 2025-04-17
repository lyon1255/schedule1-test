using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000151 RID: 337
	[Serializable]
	public class GeneratorExclude : Object
	{
		// Token: 0x06001BAA RID: 7082 RVA: 0x000C6D48 File Offset: 0x000C4F48
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratorExclude()
		{
			Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "GeneratorExclude");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr);
			GeneratorExclude.NativeFieldInfoPtr_ExcludeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "ExcludeItem");
			GeneratorExclude.NativeFieldInfoPtr_targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "targetIndex");
			GeneratorExclude.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, "exclude");
			GeneratorExclude.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr, 100666231);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000C6DC8 File Offset: 0x000C4FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100476, XrefRangeEnd = 100484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneratorExclude() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneratorExclude>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratorExclude.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0000FAA2 File Offset: 0x0000DCA2
		public GeneratorExclude(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x000C6E04 File Offset: 0x000C5004
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000FAAB File Offset: 0x0000DCAB
		public unsafe ExcludeItem ExcludeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_ExcludeItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_ExcludeItem)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x000C6E2C File Offset: 0x000C502C
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000FAC6 File Offset: 0x0000DCC6
		public unsafe int targetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_targetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_targetIndex)) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000C6E54 File Offset: 0x000C5054
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000FAE1 File Offset: 0x0000DCE1
		public unsafe List<ExcludeIndexes> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ExcludeIndexes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GeneratorExclude.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr_ExcludeItem;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_targetIndex;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
