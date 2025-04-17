using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000053 RID: 83
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x000837B0 File Offset: 0x000819B0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingComponent()
		{
			Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr);
			ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_InternalLogLutSize");
			ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_CurvePrecision");
			ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "k_CurveStep");
			ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "m_GradingCurves");
			ColorGradingComponent.NativeFieldInfoPtr_m_pixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "m_pixels");
			ColorGradingComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663914);
			ColorGradingComponent.NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663915);
			ColorGradingComponent.NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663916);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663917);
			ColorGradingComponent.NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663918);
			ColorGradingComponent.NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663919);
			ColorGradingComponent.NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663920);
			ColorGradingComponent.NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663921);
			ColorGradingComponent.NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663922);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663923);
			ColorGradingComponent.NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663924);
			ColorGradingComponent.NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663925);
			ColorGradingComponent.NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663926);
			ColorGradingComponent.NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663927);
			ColorGradingComponent.NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663928);
			ColorGradingComponent.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663929);
			ColorGradingComponent.NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663930);
			ColorGradingComponent.NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663931);
			ColorGradingComponent.NativeMethodInfoPtr_GenerateLut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663932);
			ColorGradingComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663933);
			ColorGradingComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663934);
			ColorGradingComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663935);
			ColorGradingComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, 100663936);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00083A10 File Offset: 0x00081C10
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76259, XrefRangeEnd = 76260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00083A4C File Offset: 0x00081C4C
		[CallerCount(0)]
		public unsafe float StandardIlluminantY(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00083A98 File Offset: 0x00081C98
		[CallerCount(0)]
		public unsafe Vector3 CIExyToLMS(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00083AF0 File Offset: 0x00081CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76260, XrefRangeEnd = 76261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 CalculateColorBalance(float temperature, float tint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temperature;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00083B48 File Offset: 0x00081D48
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 76263, RefRangeEnd = 76274, XrefRangeStart = 76261, XrefRangeEnd = 76263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color NormalizeColor(Color c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00083B88 File Offset: 0x00081D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76274, XrefRangeEnd = 76276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00083BE4 File Offset: 0x00081DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76276, XrefRangeEnd = 76280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetLiftValue(Color lift)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00083C24 File Offset: 0x00081E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76288, RefRangeEnd = 76289, XrefRangeStart = 76280, XrefRangeEnd = 76288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetGammaValue(Color gamma)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gamma;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00083C64 File Offset: 0x00081E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76289, XrefRangeEnd = 76296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetGainValue(Color gain)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00083CA4 File Offset: 0x00081EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76308, RefRangeEnd = 76309, XrefRangeStart = 76296, XrefRangeEnd = 76308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lift;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamma;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outLift;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outGamma;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outGain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00083D20 File Offset: 0x00081F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76309, XrefRangeEnd = 76313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetSlopeValue(Color slope)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00083D60 File Offset: 0x00081F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76313, XrefRangeEnd = 76317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPowerValue(Color power)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00083DA0 File Offset: 0x00081FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76317, XrefRangeEnd = 76321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetOffsetValue(Color offset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00083DE0 File Offset: 0x00081FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76333, RefRangeEnd = 76334, XrefRangeStart = 76321, XrefRangeEnd = 76333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slope;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outSlope;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outPower;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00083E5C File Offset: 0x0008205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76334, XrefRangeEnd = 76335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureFormat GetCurveFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00083E98 File Offset: 0x00082098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76365, RefRangeEnd = 76366, XrefRangeStart = 76335, XrefRangeEnd = 76365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetCurveTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00083ED8 File Offset: 0x000820D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76366, XrefRangeEnd = 76371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLogLutValid(RenderTexture lut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lut);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00083F28 File Offset: 0x00082128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76371, XrefRangeEnd = 76372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat GetLutFormat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00083F64 File Offset: 0x00082164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76452, RefRangeEnd = 76453, XrefRangeStart = 76372, XrefRangeEnd = 76452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateLut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_GenerateLut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00083F98 File Offset: 0x00082198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76453, XrefRangeEnd = 76477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00083FDC File Offset: 0x000821DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76477, XrefRangeEnd = 76484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00084010 File Offset: 0x00082210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76484, XrefRangeEnd = 76490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00084044 File Offset: 0x00082244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76497, RefRangeEnd = 76498, XrefRangeStart = 76490, XrefRangeEnd = 76497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00005B95 File Offset: 0x00003D95
		public ColorGradingComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00084080 File Offset: 0x00082280
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005B9E File Offset: 0x00003D9E
		public unsafe static int k_InternalLogLutSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_InternalLogLutSize, (void*)(&value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0008409C File Offset: 0x0008229C
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00005BAC File Offset: 0x00003DAC
		public unsafe static int k_CurvePrecision
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurvePrecision, (void*)(&value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000840B8 File Offset: 0x000822B8
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00005BBA File Offset: 0x00003DBA
		public unsafe static float k_CurveStep
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.NativeFieldInfoPtr_k_CurveStep, (void*)(&value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x000840D4 File Offset: 0x000822D4
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public unsafe Texture2D m_GradingCurves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_GradingCurves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00084104 File Offset: 0x00082304
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005BE7 File Offset: 0x00003DE7
		public unsafe Il2CppStructArray<Color> m_pixels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_pixels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingComponent.NativeFieldInfoPtr_m_pixels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_k_InternalLogLutSize;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_k_CurvePrecision;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_k_CurveStep;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_m_GradingCurves;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_m_pixels;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_StandardIlluminantY_Private_Single_Single_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_CIExyToLMS_Private_Vector3_Single_Single_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_CalculateColorBalance_Private_Vector3_Single_Single_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeColor_Private_Static_Color_Color_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_ClampVector_Private_Static_Vector3_Vector3_Single_Single_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_GetLiftValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_GetGammaValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_GetGainValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLiftGammaGain_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetSlopeValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetPowerValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetValue_Public_Static_Vector3_Color_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSlopePowerOffset_Public_Static_Void_Color_Color_Color_byref_Vector3_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveFormat_Private_TextureFormat_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_GetCurveTexture_Private_Texture2D_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_IsLogLutValid_Private_Boolean_RenderTexture_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_GetLutFormat_Private_RenderTextureFormat_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_GenerateLut_Private_Void_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CA RID: 1994
		public static class Uniforms : Object
		{
			// Token: 0x0600BB16 RID: 47894 RVA: 0x002E4EBC File Offset: 0x002E30BC
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr);
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LutParams");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_NeutralTonemapperParams1");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_NeutralTonemapperParams2");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_HueShift");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Saturation");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Contrast");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Balance");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Lift");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_InvGamma");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Gain");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Slope");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Power");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Offset");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerRed");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerGreen");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ChannelMixerBlue");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_Curves");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LogLut");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_LogLut_Params");
				ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingComponent.Uniforms>.NativeClassPtr, "_ExposureEV");
			}

			// Token: 0x0600BB17 RID: 47895 RVA: 0x0005B8D9 File Offset: 0x00059AD9
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039D2 RID: 14802
			// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x002E5078 File Offset: 0x002E3278
			// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x0005B8E2 File Offset: 0x00059AE2
			public unsafe static int _LutParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LutParams, (void*)(&value));
				}
			}

			// Token: 0x170039D3 RID: 14803
			// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x002E5094 File Offset: 0x002E3294
			// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x0005B8F0 File Offset: 0x00059AF0
			public unsafe static int _NeutralTonemapperParams1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams1, (void*)(&value));
				}
			}

			// Token: 0x170039D4 RID: 14804
			// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x002E50B0 File Offset: 0x002E32B0
			// (set) Token: 0x0600BB1D RID: 47901 RVA: 0x0005B8FE File Offset: 0x00059AFE
			public unsafe static int _NeutralTonemapperParams2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__NeutralTonemapperParams2, (void*)(&value));
				}
			}

			// Token: 0x170039D5 RID: 14805
			// (get) Token: 0x0600BB1E RID: 47902 RVA: 0x002E50CC File Offset: 0x002E32CC
			// (set) Token: 0x0600BB1F RID: 47903 RVA: 0x0005B90C File Offset: 0x00059B0C
			public unsafe static int _HueShift
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__HueShift, (void*)(&value));
				}
			}

			// Token: 0x170039D6 RID: 14806
			// (get) Token: 0x0600BB20 RID: 47904 RVA: 0x002E50E8 File Offset: 0x002E32E8
			// (set) Token: 0x0600BB21 RID: 47905 RVA: 0x0005B91A File Offset: 0x00059B1A
			public unsafe static int _Saturation
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Saturation, (void*)(&value));
				}
			}

			// Token: 0x170039D7 RID: 14807
			// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x002E5104 File Offset: 0x002E3304
			// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x0005B928 File Offset: 0x00059B28
			public unsafe static int _Contrast
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Contrast, (void*)(&value));
				}
			}

			// Token: 0x170039D8 RID: 14808
			// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x002E5120 File Offset: 0x002E3320
			// (set) Token: 0x0600BB25 RID: 47909 RVA: 0x0005B936 File Offset: 0x00059B36
			public unsafe static int _Balance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Balance, (void*)(&value));
				}
			}

			// Token: 0x170039D9 RID: 14809
			// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x002E513C File Offset: 0x002E333C
			// (set) Token: 0x0600BB27 RID: 47911 RVA: 0x0005B944 File Offset: 0x00059B44
			public unsafe static int _Lift
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Lift, (void*)(&value));
				}
			}

			// Token: 0x170039DA RID: 14810
			// (get) Token: 0x0600BB28 RID: 47912 RVA: 0x002E5158 File Offset: 0x002E3358
			// (set) Token: 0x0600BB29 RID: 47913 RVA: 0x0005B952 File Offset: 0x00059B52
			public unsafe static int _InvGamma
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__InvGamma, (void*)(&value));
				}
			}

			// Token: 0x170039DB RID: 14811
			// (get) Token: 0x0600BB2A RID: 47914 RVA: 0x002E5174 File Offset: 0x002E3374
			// (set) Token: 0x0600BB2B RID: 47915 RVA: 0x0005B960 File Offset: 0x00059B60
			public unsafe static int _Gain
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Gain, (void*)(&value));
				}
			}

			// Token: 0x170039DC RID: 14812
			// (get) Token: 0x0600BB2C RID: 47916 RVA: 0x002E5190 File Offset: 0x002E3390
			// (set) Token: 0x0600BB2D RID: 47917 RVA: 0x0005B96E File Offset: 0x00059B6E
			public unsafe static int _Slope
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Slope, (void*)(&value));
				}
			}

			// Token: 0x170039DD RID: 14813
			// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x002E51AC File Offset: 0x002E33AC
			// (set) Token: 0x0600BB2F RID: 47919 RVA: 0x0005B97C File Offset: 0x00059B7C
			public unsafe static int _Power
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Power, (void*)(&value));
				}
			}

			// Token: 0x170039DE RID: 14814
			// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x002E51C8 File Offset: 0x002E33C8
			// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x0005B98A File Offset: 0x00059B8A
			public unsafe static int _Offset
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Offset, (void*)(&value));
				}
			}

			// Token: 0x170039DF RID: 14815
			// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x002E51E4 File Offset: 0x002E33E4
			// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x0005B998 File Offset: 0x00059B98
			public unsafe static int _ChannelMixerRed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerRed, (void*)(&value));
				}
			}

			// Token: 0x170039E0 RID: 14816
			// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x002E5200 File Offset: 0x002E3400
			// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x0005B9A6 File Offset: 0x00059BA6
			public unsafe static int _ChannelMixerGreen
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&value));
				}
			}

			// Token: 0x170039E1 RID: 14817
			// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x002E521C File Offset: 0x002E341C
			// (set) Token: 0x0600BB37 RID: 47927 RVA: 0x0005B9B4 File Offset: 0x00059BB4
			public unsafe static int _ChannelMixerBlue
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&value));
				}
			}

			// Token: 0x170039E2 RID: 14818
			// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x002E5238 File Offset: 0x002E3438
			// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x0005B9C2 File Offset: 0x00059BC2
			public unsafe static int _Curves
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__Curves, (void*)(&value));
				}
			}

			// Token: 0x170039E3 RID: 14819
			// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x002E5254 File Offset: 0x002E3454
			// (set) Token: 0x0600BB3B RID: 47931 RVA: 0x0005B9D0 File Offset: 0x00059BD0
			public unsafe static int _LogLut
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut, (void*)(&value));
				}
			}

			// Token: 0x170039E4 RID: 14820
			// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x002E5270 File Offset: 0x002E3470
			// (set) Token: 0x0600BB3D RID: 47933 RVA: 0x0005B9DE File Offset: 0x00059BDE
			public unsafe static int _LogLut_Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__LogLut_Params, (void*)(&value));
				}
			}

			// Token: 0x170039E5 RID: 14821
			// (get) Token: 0x0600BB3E RID: 47934 RVA: 0x002E528C File Offset: 0x002E348C
			// (set) Token: 0x0600BB3F RID: 47935 RVA: 0x0005B9EC File Offset: 0x00059BEC
			public unsafe static int _ExposureEV
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorGradingComponent.Uniforms.NativeFieldInfoPtr__ExposureEV, (void*)(&value));
				}
			}

			// Token: 0x04007E26 RID: 32294
			private static readonly IntPtr NativeFieldInfoPtr__LutParams;

			// Token: 0x04007E27 RID: 32295
			private static readonly IntPtr NativeFieldInfoPtr__NeutralTonemapperParams1;

			// Token: 0x04007E28 RID: 32296
			private static readonly IntPtr NativeFieldInfoPtr__NeutralTonemapperParams2;

			// Token: 0x04007E29 RID: 32297
			private static readonly IntPtr NativeFieldInfoPtr__HueShift;

			// Token: 0x04007E2A RID: 32298
			private static readonly IntPtr NativeFieldInfoPtr__Saturation;

			// Token: 0x04007E2B RID: 32299
			private static readonly IntPtr NativeFieldInfoPtr__Contrast;

			// Token: 0x04007E2C RID: 32300
			private static readonly IntPtr NativeFieldInfoPtr__Balance;

			// Token: 0x04007E2D RID: 32301
			private static readonly IntPtr NativeFieldInfoPtr__Lift;

			// Token: 0x04007E2E RID: 32302
			private static readonly IntPtr NativeFieldInfoPtr__InvGamma;

			// Token: 0x04007E2F RID: 32303
			private static readonly IntPtr NativeFieldInfoPtr__Gain;

			// Token: 0x04007E30 RID: 32304
			private static readonly IntPtr NativeFieldInfoPtr__Slope;

			// Token: 0x04007E31 RID: 32305
			private static readonly IntPtr NativeFieldInfoPtr__Power;

			// Token: 0x04007E32 RID: 32306
			private static readonly IntPtr NativeFieldInfoPtr__Offset;

			// Token: 0x04007E33 RID: 32307
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerRed;

			// Token: 0x04007E34 RID: 32308
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerGreen;

			// Token: 0x04007E35 RID: 32309
			private static readonly IntPtr NativeFieldInfoPtr__ChannelMixerBlue;

			// Token: 0x04007E36 RID: 32310
			private static readonly IntPtr NativeFieldInfoPtr__Curves;

			// Token: 0x04007E37 RID: 32311
			private static readonly IntPtr NativeFieldInfoPtr__LogLut;

			// Token: 0x04007E38 RID: 32312
			private static readonly IntPtr NativeFieldInfoPtr__LogLut_Params;

			// Token: 0x04007E39 RID: 32313
			private static readonly IntPtr NativeFieldInfoPtr__ExposureEV;
		}
	}
}
