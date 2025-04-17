using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D0 RID: 1488
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008311 RID: 33553 RVA: 0x0022DAA0 File Offset: 0x0022BCA0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemDefinition()
		{
			Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "BuildableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr);
			BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuiltItem");
			BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuildSoundType");
			BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, 100679695);
		}

		// Token: 0x06008312 RID: 33554 RVA: 0x0022DB0C File Offset: 0x0022BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008313 RID: 33555 RVA: 0x0003E4BA File Offset: 0x0003C6BA
		public BuildableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x0022DB48 File Offset: 0x0022BD48
		// (set) Token: 0x06008315 RID: 33557 RVA: 0x0003E4C3 File Offset: 0x0003C6C3
		public unsafe BuildableItem BuiltItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x0022DB78 File Offset: 0x0022BD78
		// (set) Token: 0x06008317 RID: 33559 RVA: 0x0003E4E2 File Offset: 0x0003C6E2
		public unsafe BuildableItemDefinition.EBuildSoundType BuildSoundType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType)) = value;
			}
		}

		// Token: 0x04005930 RID: 22832
		private static readonly IntPtr NativeFieldInfoPtr_BuiltItem;

		// Token: 0x04005931 RID: 22833
		private static readonly IntPtr NativeFieldInfoPtr_BuildSoundType;

		// Token: 0x04005932 RID: 22834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE5 RID: 2789
		[OriginalName("Assembly-CSharp.dll", "", "EBuildSoundType")]
		public enum EBuildSoundType
		{
			// Token: 0x04008F71 RID: 36721
			Cardboard,
			// Token: 0x04008F72 RID: 36722
			Wood,
			// Token: 0x04008F73 RID: 36723
			Metal
		}
	}
}
