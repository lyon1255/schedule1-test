using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E0 RID: 224
	public class LightningArtItem : SpriteArtItem
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x000A8FC0 File Offset: 0x000A71C0
		// Note: this type is marked as 'beforefieldinit'.
		static LightningArtItem()
		{
			Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LightningArtItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr);
			LightningArtItem.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "alignment");
			LightningArtItem.NativeFieldInfoPtr_thunderSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "thunderSound");
			LightningArtItem.NativeFieldInfoPtr_strikeProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "strikeProbability");
			LightningArtItem.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "size");
			LightningArtItem.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, "intensity");
			LightningArtItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr, 100665366);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x000A9068 File Offset: 0x000A7268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88925, XrefRangeEnd = 88926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningArtItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningArtItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningArtItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0000AEE7 File Offset: 0x000090E7
		public LightningArtItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x000A90A4 File Offset: 0x000A72A4
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public unsafe LightningArtItem.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000A90CC File Offset: 0x000A72CC
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x0000AF0B File Offset: 0x0000910B
		public unsafe AudioClip thunderSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_thunderSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_thunderSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x000A90FC File Offset: 0x000A72FC
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x0000AF2A File Offset: 0x0000912A
		public unsafe float strikeProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_strikeProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_strikeProbability)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000A9124 File Offset: 0x000A7324
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0000AF45 File Offset: 0x00009145
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000A914C File Offset: 0x000A734C
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x0000AF60 File Offset: 0x00009160
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningArtItem.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_thunderSound;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_strikeProbability;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084E RID: 2126
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x04008237 RID: 33335
			ScaleToFit,
			// Token: 0x04008238 RID: 33336
			TopAlign
		}
	}
}
