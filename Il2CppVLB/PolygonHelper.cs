using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A7 RID: 167
	public class PolygonHelper : MonoBehaviour
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00007BAE File Offset: 0x00005DAE
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonHelper()
		{
			Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "PolygonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr);
			PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, 100664641);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00094718 File Offset: 0x00092918
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00007BE7 File Offset: 0x00005DE7
		public PolygonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200082D RID: 2093
		[StructLayout(2)]
		public struct Plane2D
		{
			// Token: 0x0600BEB9 RID: 48825 RVA: 0x002ECBC4 File Offset: 0x002EADC4
			// Note: this type is marked as 'beforefieldinit'.
			static Plane2D()
			{
				Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, "Plane2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr);
				PolygonHelper.Plane2D.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "normal");
				PolygonHelper.Plane2D.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "distance");
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664642);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664643);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664644);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664645);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664646);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664647);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664648);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664649);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664650);
			}

			// Token: 0x0600BEBA RID: 48826 RVA: 0x002ECCCC File Offset: 0x002EAECC
			[CallerCount(0)]
			public unsafe float Distance(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBB RID: 48827 RVA: 0x002ECD0C File Offset: 0x002EAF0C
			[CallerCount(0)]
			public unsafe Vector2 ClosestPoint(Vector2 pt)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBC RID: 48828 RVA: 0x002ECD4C File Offset: 0x002EAF4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 82741, RefRangeEnd = 82743, XrefRangeStart = 82741, XrefRangeEnd = 82741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBD RID: 48829 RVA: 0x002ECD98 File Offset: 0x002EAF98
			[CallerCount(0)]
			public unsafe bool GetSide(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBE RID: 48830 RVA: 0x002ECDD8 File Offset: 0x002EAFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82743, XrefRangeEnd = 82744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PolygonHelper.Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEBF RID: 48831 RVA: 0x002ECE24 File Offset: 0x002EB024
			[CallerCount(0)]
			public unsafe static PolygonHelper.Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref normalizedNormal;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BEC0 RID: 48832 RVA: 0x002ECE70 File Offset: 0x002EB070
			[CallerCount(0)]
			public unsafe void Flip()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEC1 RID: 48833 RVA: 0x002ECE98 File Offset: 0x002EB098
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82765, RefRangeEnd = 82766, XrefRangeStart = 82744, XrefRangeEnd = 82765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<Vector2> CutConvex(Il2CppStructArray<Vector2> poly)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}

			// Token: 0x0600BEC2 RID: 48834 RVA: 0x002ECEDC File Offset: 0x002EB0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82766, XrefRangeEnd = 82776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BEC3 RID: 48835 RVA: 0x0005D418 File Offset: 0x0005B618
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, ref this));
			}

			// Token: 0x0400813A RID: 33082
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x0400813B RID: 33083
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x0400813C RID: 33084
			private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Single_Vector2_0;

			// Token: 0x0400813D RID: 33085
			private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0;

			// Token: 0x0400813E RID: 33086
			private static readonly IntPtr NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0;

			// Token: 0x0400813F RID: 33087
			private static readonly IntPtr NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0;

			// Token: 0x04008140 RID: 33088
			private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008141 RID: 33089
			private static readonly IntPtr NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008142 RID: 33090
			private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Void_0;

			// Token: 0x04008143 RID: 33091
			private static readonly IntPtr NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0;

			// Token: 0x04008144 RID: 33092
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04008145 RID: 33093
			[FieldOffset(0)]
			public Vector2 normal;

			// Token: 0x04008146 RID: 33094
			[FieldOffset(8)]
			public float distance;
		}
	}
}
