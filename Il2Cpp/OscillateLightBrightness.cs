using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000045 RID: 69
	public class OscillateLightBrightness : MonoBehaviour
	{
		// Token: 0x060005CE RID: 1486 RVA: 0x00081B1C File Offset: 0x0007FD1C
		// Note: this type is marked as 'beforefieldinit'.
		static OscillateLightBrightness()
		{
			Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OscillateLightBrightness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr);
			OscillateLightBrightness.NativeFieldInfoPtr_lightComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lightComponent");
			OscillateLightBrightness.NativeFieldInfoPtr_lower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "lower");
			OscillateLightBrightness.NativeFieldInfoPtr_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, "upper");
			OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663848);
			OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663849);
			OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr, 100663850);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00081BC4 File Offset: 0x0007FDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75610, XrefRangeEnd = 75614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00081BF8 File Offset: 0x0007FDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75614, XrefRangeEnd = 75617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00081C2C File Offset: 0x0007FE2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OscillateLightBrightness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OscillateLightBrightness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OscillateLightBrightness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000568D File Offset: 0x0000388D
		public OscillateLightBrightness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00081C68 File Offset: 0x0007FE68
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00005696 File Offset: 0x00003896
		public unsafe Light lightComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lightComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00081C98 File Offset: 0x0007FE98
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x000056B5 File Offset: 0x000038B5
		public unsafe float lower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_lower)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00081CC0 File Offset: 0x0007FEC0
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x000056D0 File Offset: 0x000038D0
		public unsafe float upper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OscillateLightBrightness.NativeFieldInfoPtr_upper)) = value;
			}
		}

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_lightComponent;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_lower;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_upper;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
