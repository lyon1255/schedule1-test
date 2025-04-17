using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x02000099 RID: 153
	[Serializable]
	public class RaymarchingQuality : Object
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x0008EA00 File Offset: 0x0008CC00
		// Note: this type is marked as 'beforefieldinit'.
		static RaymarchingQuality()
		{
			Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "RaymarchingQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr);
			RaymarchingQuality.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "name");
			RaymarchingQuality.NativeFieldInfoPtr_stepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "stepCount");
			RaymarchingQuality.NativeFieldInfoPtr__UniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "_UniqueID");
			RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "ms_DefaultInstance");
			RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "kRandomUniqueIdMinRange");
			RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664368);
			RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664369);
			RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664370);
			RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664371);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664372);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664373);
			RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100664374);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0008EB20 File Offset: 0x0008CD20
		public unsafe int uniqueID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0008EB5C File Offset: 0x0008CD5C
		public unsafe bool hasValidUniqueID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0008EB98 File Offset: 0x0008CD98
		public unsafe static RaymarchingQuality defaultInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80815, XrefRangeEnd = 80819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0008EBCC File Offset: 0x0008CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80819, XrefRangeEnd = 80824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality(int uniqueID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uniqueID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0008EC14 File Offset: 0x0008CE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80824, XrefRangeEnd = 80833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0008EC48 File Offset: 0x0008CE48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80845, XrefRangeStart = 80833, XrefRangeEnd = 80842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forcedUniqueID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0008ECA8 File Offset: 0x0008CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80845, XrefRangeEnd = 80846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRaymarchingQualityWithSameUniqueID(Il2CppReferenceArray<RaymarchingQuality> values, int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00007395 File Offset: 0x00005595
		public RaymarchingQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0008ECF8 File Offset: 0x0008CEF8
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000739E File Offset: 0x0000559E
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0008ED20 File Offset: 0x0008CF20
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x000073BD File Offset: 0x000055BD
		public unsafe int stepCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0008ED48 File Offset: 0x0008CF48
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x000073D8 File Offset: 0x000055D8
		public unsafe int _UniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID)) = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0008ED70 File Offset: 0x0008CF70
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x000073F3 File Offset: 0x000055F3
		public unsafe static RaymarchingQuality ms_DefaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0008ED98 File Offset: 0x0008CF98
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00007405 File Offset: 0x00005605
		public unsafe static int kRandomUniqueIdMinRange
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&value));
			}
		}

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_stepCount;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr__UniqueID;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_ms_DefaultInstance;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_kRandomUniqueIdMinRange;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0;
	}
}
