using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000196 RID: 406
	[Serializable]
	public class Coordinate : Il2CppSystem.Object
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x000D96B0 File Offset: 0x000D78B0
		// Note: this type is marked as 'beforefieldinit'.
		static Coordinate()
		{
			Il2CppClassPointerStore<Coordinate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Coordinate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coordinate>.NativeClassPtr);
			Coordinate.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, "x");
			Coordinate.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, "y");
			Coordinate.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667097);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667098);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667099);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667100);
			Coordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667101);
			Coordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667102);
			Coordinate.NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667103);
			Coordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667104);
			Coordinate.NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667105);
			Coordinate.NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667106);
			Coordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667107);
			Coordinate.NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667108);
			Coordinate.NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667109);
			Coordinate.NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667110);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000D9820 File Offset: 0x000D7A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110511, RefRangeEnd = 110513, XrefRangeStart = 110511, XrefRangeEnd = 110511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(Coordinate c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000D9864 File Offset: 0x000D7A64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110514, RefRangeEnd = 110516, XrefRangeStart = 110513, XrefRangeEnd = 110514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000D98A0 File Offset: 0x000D7AA0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 110517, RefRangeEnd = 110534, XrefRangeStart = 110516, XrefRangeEnd = 110517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate(int _x, int _y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000D98F8 File Offset: 0x000D7AF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 110535, RefRangeEnd = 110542, XrefRangeStart = 110534, XrefRangeEnd = 110535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate(Vector2 vector) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000D9940 File Offset: 0x000D7B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110542, XrefRangeEnd = 110544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000D9988 File Offset: 0x000D7B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110544, XrefRangeEnd = 110546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000D99E0 File Offset: 0x000D7BE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110550, RefRangeEnd = 110554, XrefRangeStart = 110546, XrefRangeEnd = 110550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate operator +(Coordinate a, Coordinate b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000D9A38 File Offset: 0x000D7C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110554, XrefRangeEnd = 110558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate operator -(Coordinate a, Coordinate b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000D9A90 File Offset: 0x000D7C90
		[CallerCount(0)]
		public unsafe int CantorPair(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000D9AE8 File Offset: 0x000D7CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110558, XrefRangeEnd = 110560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SignedCantorPair(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000D9B40 File Offset: 0x000D7D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110560, XrefRangeEnd = 110579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000D9B84 File Offset: 0x000D7D84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110615, RefRangeEnd = 110619, XrefRangeStart = 110579, XrefRangeEnd = 110615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr3) : null;
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000D9BF4 File Offset: 0x000D7DF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110632, RefRangeEnd = 110636, XrefRangeStart = 110619, XrefRangeEnd = 110632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000D9C48 File Offset: 0x000D7E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110636, XrefRangeEnd = 110639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MathMod(int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00012BA7 File Offset: 0x00010DA7
		public Coordinate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000D9C94 File Offset: 0x000D7E94
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00012BB0 File Offset: 0x00010DB0
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000D9CBC File Offset: 0x000D7EBC
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00012BCB File Offset: 0x00010DCB
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0;
	}
}
