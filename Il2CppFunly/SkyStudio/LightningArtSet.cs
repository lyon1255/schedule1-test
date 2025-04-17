using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E1 RID: 225
	public class LightningArtSet : SpriteArtSet
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x000A9174 File Offset: 0x000A7374
		// Note: this type is marked as 'beforefieldinit'.
		static LightningArtSet()
		{
			Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningArtSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr);
			LightningArtSet.NativeFieldInfoPtr_lightingStyleItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr, "lightingStyleItems");
			LightningArtSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr, 100665367);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000A91CC File Offset: 0x000A73CC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningArtSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningArtSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningArtSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000AF7B File Offset: 0x0000917B
		public LightningArtSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000A9208 File Offset: 0x000A7408
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000AF84 File Offset: 0x00009184
		public unsafe List<LightningArtItem> lightingStyleItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtSet.NativeFieldInfoPtr_lightingStyleItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LightningArtItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtSet.NativeFieldInfoPtr_lightingStyleItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr_lightingStyleItems;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
