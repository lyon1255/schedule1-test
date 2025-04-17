using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005CF RID: 1487
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x0600830C RID: 33548 RVA: 0x0022D9DC File Offset: 0x0022BBDC
		// Note: this type is marked as 'beforefieldinit'.
		static AdditiveDefinition()
		{
			Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "AdditiveDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr);
			AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "AdditivePrefab");
			AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100679694);
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x0022DA34 File Offset: 0x0022BC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditiveDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x0003E492 File Offset: 0x0003C692
		public AdditiveDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600830F RID: 33551 RVA: 0x0022DA70 File Offset: 0x0022BC70
		// (set) Token: 0x06008310 RID: 33552 RVA: 0x0003E49B File Offset: 0x0003C69B
		public unsafe Additive AdditivePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr_AdditivePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400592E RID: 22830
		private static readonly IntPtr NativeFieldInfoPtr_AdditivePrefab;

		// Token: 0x0400592F RID: 22831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
