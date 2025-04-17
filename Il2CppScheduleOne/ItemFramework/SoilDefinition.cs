using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005CE RID: 1486
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x060082FF RID: 33535 RVA: 0x0022D820 File Offset: 0x0022BA20
		// Note: this type is marked as 'beforefieldinit'.
		static SoilDefinition()
		{
			Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SoilDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr);
			SoilDefinition.NativeFieldInfoPtr_SoilQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "SoilQuality");
			SoilDefinition.NativeFieldInfoPtr_DrySoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "DrySoilMat");
			SoilDefinition.NativeFieldInfoPtr_WetSoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "WetSoilMat");
			SoilDefinition.NativeFieldInfoPtr_ParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "ParticleColor");
			SoilDefinition.NativeFieldInfoPtr_Uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "Uses");
			SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, 100679693);
		}

		// Token: 0x06008300 RID: 33536 RVA: 0x0022D8C8 File Offset: 0x0022BAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246916, XrefRangeEnd = 246917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x0003E3FA File Offset: 0x0003C5FA
		public SoilDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x06008302 RID: 33538 RVA: 0x0022D904 File Offset: 0x0022BB04
		// (set) Token: 0x06008303 RID: 33539 RVA: 0x0003E403 File Offset: 0x0003C603
		public unsafe SoilDefinition.ESoilQuality SoilQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality)) = value;
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x06008304 RID: 33540 RVA: 0x0022D92C File Offset: 0x0022BB2C
		// (set) Token: 0x06008305 RID: 33541 RVA: 0x0003E41E File Offset: 0x0003C61E
		public unsafe Material DrySoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06008306 RID: 33542 RVA: 0x0022D95C File Offset: 0x0022BB5C
		// (set) Token: 0x06008307 RID: 33543 RVA: 0x0003E43D File Offset: 0x0003C63D
		public unsafe Material WetSoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x0022D98C File Offset: 0x0022BB8C
		// (set) Token: 0x06008309 RID: 33545 RVA: 0x0003E45C File Offset: 0x0003C65C
		public unsafe Color ParticleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor)) = value;
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x0022D9B4 File Offset: 0x0022BBB4
		// (set) Token: 0x0600830B RID: 33547 RVA: 0x0003E477 File Offset: 0x0003C677
		public unsafe int Uses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses)) = value;
			}
		}

		// Token: 0x04005928 RID: 22824
		private static readonly IntPtr NativeFieldInfoPtr_SoilQuality;

		// Token: 0x04005929 RID: 22825
		private static readonly IntPtr NativeFieldInfoPtr_DrySoilMat;

		// Token: 0x0400592A RID: 22826
		private static readonly IntPtr NativeFieldInfoPtr_WetSoilMat;

		// Token: 0x0400592B RID: 22827
		private static readonly IntPtr NativeFieldInfoPtr_ParticleColor;

		// Token: 0x0400592C RID: 22828
		private static readonly IntPtr NativeFieldInfoPtr_Uses;

		// Token: 0x0400592D RID: 22829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE4 RID: 2788
		[OriginalName("Assembly-CSharp.dll", "", "ESoilQuality")]
		public enum ESoilQuality
		{
			// Token: 0x04008F6E RID: 36718
			Basic,
			// Token: 0x04008F6F RID: 36719
			Premium
		}
	}
}
