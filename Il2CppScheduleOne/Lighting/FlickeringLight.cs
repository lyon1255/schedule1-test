using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B4 RID: 948
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x060049DC RID: 18908 RVA: 0x00167550 File Offset: 0x00165750
		// Note: this type is marked as 'beforefieldinit'.
		static FlickeringLight()
		{
			Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "FlickeringLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr);
			FlickeringLight.NativeFieldInfoPtr_minIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minIntensity");
			FlickeringLight.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxIntensity");
			FlickeringLight.NativeFieldInfoPtr_enableColorShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "enableColorShift");
			FlickeringLight.NativeFieldInfoPtr_minColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minColor");
			FlickeringLight.NativeFieldInfoPtr_maxColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxColor");
			FlickeringLight.NativeFieldInfoPtr_flickerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "flickerSpeed");
			FlickeringLight.NativeFieldInfoPtr_lightSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "lightSource");
			FlickeringLight.NativeFieldInfoPtr_targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetIntensity");
			FlickeringLight.NativeFieldInfoPtr_targetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetColor");
			FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672468);
			FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672469);
			FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672470);
			FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672471);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00167684 File Offset: 0x00165884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163582, XrefRangeEnd = 163587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001676B8 File Offset: 0x001658B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163587, XrefRangeEnd = 163597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x001676EC File Offset: 0x001658EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163600, RefRangeEnd = 163602, XrefRangeStart = 163597, XrefRangeEnd = 163600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00167720 File Offset: 0x00165920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163602, XrefRangeEnd = 163603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlickeringLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x0002391E File Offset: 0x00021B1E
		public FlickeringLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x0016775C File Offset: 0x0016595C
		// (set) Token: 0x060049E3 RID: 18915 RVA: 0x00023927 File Offset: 0x00021B27
		public unsafe float minIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity)) = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00167784 File Offset: 0x00165984
		// (set) Token: 0x060049E5 RID: 18917 RVA: 0x00023942 File Offset: 0x00021B42
		public unsafe float maxIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity)) = value;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x001677AC File Offset: 0x001659AC
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x0002395D File Offset: 0x00021B5D
		public unsafe bool enableColorShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift)) = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x001677D4 File Offset: 0x001659D4
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x00023978 File Offset: 0x00021B78
		public unsafe Color minColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor)) = value;
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x001677FC File Offset: 0x001659FC
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x00023993 File Offset: 0x00021B93
		public unsafe Color maxColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor)) = value;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00167824 File Offset: 0x00165A24
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x000239AE File Offset: 0x00021BAE
		public unsafe float flickerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed)) = value;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x0016784C File Offset: 0x00165A4C
		// (set) Token: 0x060049EF RID: 18927 RVA: 0x000239C9 File Offset: 0x00021BC9
		public unsafe Light lightSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x0016787C File Offset: 0x00165A7C
		// (set) Token: 0x060049F1 RID: 18929 RVA: 0x000239E8 File Offset: 0x00021BE8
		public unsafe float targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity)) = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x001678A4 File Offset: 0x00165AA4
		// (set) Token: 0x060049F3 RID: 18931 RVA: 0x00023A03 File Offset: 0x00021C03
		public unsafe Color targetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor)) = value;
			}
		}

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeFieldInfoPtr_minIntensity;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeFieldInfoPtr_enableColorShift;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeFieldInfoPtr_minColor;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeFieldInfoPtr_maxColor;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeFieldInfoPtr_flickerSpeed;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeFieldInfoPtr_lightSource;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeFieldInfoPtr_targetIntensity;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeFieldInfoPtr_targetColor;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
