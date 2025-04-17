using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A2 RID: 162
	public static class MeshGenerator : Il2CppSystem.Object
	{
		// Token: 0x06000B16 RID: 2838 RVA: 0x000936FC File Offset: 0x000918FC
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerator()
		{
			Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MeshGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr);
			MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "kMinTruncatedRadius");
			MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664597);
			MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664598);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664599);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664600);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664601);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664602);
			MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664603);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664604);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664605);
			MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664606);
			MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664607);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664608);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664609);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664610);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664611);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0009386C File Offset: 0x00091A6C
		[CallerCount(0)]
		public unsafe static float GetAngleOffset(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000938AC File Offset: 0x00091AAC
		[CallerCount(0)]
		public unsafe static float GetRadiiScale(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000938EC File Offset: 0x00091AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82516, XrefRangeEnd = 82518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00093980 File Offset: 0x00091B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82518, XrefRangeEnd = 82520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00093A08 File Offset: 0x00091C08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82568, RefRangeEnd = 82572, XrefRangeStart = 82520, XrefRangeEnd = 82568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00093A9C File Offset: 0x00091C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82624, RefRangeEnd = 82625, XrefRangeStart = 82572, XrefRangeEnd = 82624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00093B14 File Offset: 0x00091D14
		[CallerCount(0)]
		public unsafe static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00093B70 File Offset: 0x00091D70
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalVerticesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00093BBC File Offset: 0x00091DBC
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalIndicesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00093C08 File Offset: 0x00091E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82625, XrefRangeEnd = 82629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetVertexCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00093C70 File Offset: 0x00091E70
		[CallerCount(0)]
		public unsafe static int GetIndicesCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00093CD8 File Offset: 0x00091ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82629, XrefRangeEnd = 82633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00093D08 File Offset: 0x00091F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82633, XrefRangeEnd = 82637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00093D38 File Offset: 0x00091F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82637, XrefRangeEnd = 82638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00093D68 File Offset: 0x00091F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82638, XrefRangeEnd = 82639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public MeshGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00093D98 File Offset: 0x00091F98
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00007B01 File Offset: 0x00005D01
		public unsafe static float kMinTruncatedRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&value));
			}
		}

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_kMinTruncatedRadius;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0;

		// Token: 0x0200082A RID: 2090
		[OriginalName("Assembly-CSharp.dll", "", "CapMode")]
		public enum CapMode
		{
			// Token: 0x04008129 RID: 33065
			None,
			// Token: 0x0400812A RID: 33066
			OneVertexPerCap_1Cap,
			// Token: 0x0400812B RID: 33067
			OneVertexPerCap_2Caps,
			// Token: 0x0400812C RID: 33068
			SpecificVerticesPerCap_1Cap,
			// Token: 0x0400812D RID: 33069
			SpecificVerticesPerCap_2Caps
		}

		// Token: 0x0200082B RID: 2091
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BEA2 RID: 48802 RVA: 0x002EC7E8 File Offset: 0x002EA9E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "numSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCountSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertSidesStartFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCenterFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664612);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664613);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664614);
			}

			// Token: 0x0600BEA3 RID: 48803 RVA: 0x002EC8A0 File Offset: 0x002EAAA0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEA4 RID: 48804 RVA: 0x002EC8DC File Offset: 0x002EAADC
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__0(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEA5 RID: 48805 RVA: 0x002EC928 File Offset: 0x002EAB28
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__1(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEA6 RID: 48806 RVA: 0x0005D339 File Offset: 0x0005B539
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B48 RID: 15176
			// (get) Token: 0x0600BEA7 RID: 48807 RVA: 0x002EC974 File Offset: 0x002EAB74
			// (set) Token: 0x0600BEA8 RID: 48808 RVA: 0x0005D342 File Offset: 0x0005B542
			public unsafe int numSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides)) = value;
				}
			}

			// Token: 0x17003B49 RID: 15177
			// (get) Token: 0x0600BEA9 RID: 48809 RVA: 0x002EC99C File Offset: 0x002EAB9C
			// (set) Token: 0x0600BEAA RID: 48810 RVA: 0x0005D35D File Offset: 0x0005B55D
			public unsafe int vertCountSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides)) = value;
				}
			}

			// Token: 0x17003B4A RID: 15178
			// (get) Token: 0x0600BEAB RID: 48811 RVA: 0x002EC9C4 File Offset: 0x002EABC4
			// (set) Token: 0x0600BEAC RID: 48812 RVA: 0x0005D378 File Offset: 0x0005B578
			public unsafe Func<int, int> vertSidesStartFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B4B RID: 15179
			// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x002EC9F4 File Offset: 0x002EABF4
			// (set) Token: 0x0600BEAE RID: 48814 RVA: 0x0005D397 File Offset: 0x0005B597
			public unsafe Func<int, int> vertCenterFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400812E RID: 33070
			private static readonly IntPtr NativeFieldInfoPtr_numSides;

			// Token: 0x0400812F RID: 33071
			private static readonly IntPtr NativeFieldInfoPtr_vertCountSides;

			// Token: 0x04008130 RID: 33072
			private static readonly IntPtr NativeFieldInfoPtr_vertSidesStartFromSlide;

			// Token: 0x04008131 RID: 33073
			private static readonly IntPtr NativeFieldInfoPtr_vertCenterFromSlide;

			// Token: 0x04008132 RID: 33074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008133 RID: 33075
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0;

			// Token: 0x04008134 RID: 33076
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0;
		}

		// Token: 0x0200082C RID: 2092
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BEAF RID: 48815 RVA: 0x002ECA24 File Offset: 0x002EAC24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "indices");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "ind");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664615);
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664616);
			}

			// Token: 0x0600BEB0 RID: 48816 RVA: 0x002ECAB4 File Offset: 0x002EACB4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB1 RID: 48817 RVA: 0x002ECAF0 File Offset: 0x002EACF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82515, XrefRangeEnd = 82516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateConeZ_Radii_DoubleCaps_b__2(int slideID, bool invert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEB2 RID: 48818 RVA: 0x0005D3B6 File Offset: 0x0005B5B6
			public __c__DisplayClass6_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B4C RID: 15180
			// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x002ECB3C File Offset: 0x002EAD3C
			// (set) Token: 0x0600BEB4 RID: 48820 RVA: 0x0005D3BF File Offset: 0x0005B5BF
			public unsafe Il2CppStructArray<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B4D RID: 15181
			// (get) Token: 0x0600BEB5 RID: 48821 RVA: 0x002ECB6C File Offset: 0x002EAD6C
			// (set) Token: 0x0600BEB6 RID: 48822 RVA: 0x0005D3DE File Offset: 0x0005B5DE
			public unsafe int ind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind)) = value;
				}
			}

			// Token: 0x17003B4E RID: 15182
			// (get) Token: 0x0600BEB7 RID: 48823 RVA: 0x002ECB94 File Offset: 0x002EAD94
			// (set) Token: 0x0600BEB8 RID: 48824 RVA: 0x0005D3F9 File Offset: 0x0005B5F9
			public unsafe MeshGenerator.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGenerator.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008135 RID: 33077
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x04008136 RID: 33078
			private static readonly IntPtr NativeFieldInfoPtr_ind;

			// Token: 0x04008137 RID: 33079
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x04008138 RID: 33080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008139 RID: 33081
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0;
		}
	}
}
