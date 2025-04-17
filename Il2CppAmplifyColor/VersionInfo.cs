using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000795 RID: 1941
	[Serializable]
	public class VersionInfo : Object
	{
		// Token: 0x0600B7C5 RID: 47045 RVA: 0x002D9CEC File Offset: 0x002D7EEC
		// Note: this type is marked as 'beforefieldinit'.
		static VersionInfo()
		{
			Il2CppClassPointerStore<VersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr);
			VersionInfo.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Major");
			VersionInfo.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Minor");
			VersionInfo.NativeFieldInfoPtr_Release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "Release");
			VersionInfo.NativeFieldInfoPtr_StageSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "StageSuffix");
			VersionInfo.NativeFieldInfoPtr_TrialSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "TrialSuffix");
			VersionInfo.NativeFieldInfoPtr_m_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_major");
			VersionInfo.NativeFieldInfoPtr_m_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_minor");
			VersionInfo.NativeFieldInfoPtr_m_release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "m_release");
			VersionInfo.NativeMethodInfoPtr_StaticToString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685875);
			VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685876);
			VersionInfo.NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685877);
			VersionInfo.NativeMethodInfoPtr_get_Number_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685878);
			VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685879);
			VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685880);
			VersionInfo.NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685881);
			VersionInfo.NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100685882);
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x002D9E5C File Offset: 0x002D805C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312548, XrefRangeEnd = 312563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StaticToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_StaticToString_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x002D9E88 File Offset: 0x002D8088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312563, XrefRangeEnd = 312578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600B7C8 RID: 47048 RVA: 0x002D9ECC File Offset: 0x002D80CC
		public unsafe static int FullNumber
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x002D9EFC File Offset: 0x002D80FC
		public unsafe int Number
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_get_Number_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x002D9F38 File Offset: 0x002D8138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312578, XrefRangeEnd = 312579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002D9F74 File Offset: 0x002D8174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312579, XrefRangeEnd = 312580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo(byte major, byte minor, byte release) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref major;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref release;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x002D9FD8 File Offset: 0x002D81D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312580, XrefRangeEnd = 312584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VersionInfo Current()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VersionInfo>(intPtr3) : null;
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002DA00C File Offset: 0x002D820C
		[CallerCount(0)]
		public unsafe static bool Matches(VersionInfo version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionInfo.NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x0005A3AB File Offset: 0x000585AB
		public VersionInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600B7CF RID: 47055 RVA: 0x002DA050 File Offset: 0x002D8250
		// (set) Token: 0x0600B7D0 RID: 47056 RVA: 0x0005A3B4 File Offset: 0x000585B4
		public unsafe static byte Major
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Major, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Major, (void*)(&value));
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600B7D1 RID: 47057 RVA: 0x002DA06C File Offset: 0x002D826C
		// (set) Token: 0x0600B7D2 RID: 47058 RVA: 0x0005A3C2 File Offset: 0x000585C2
		public unsafe static byte Minor
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Minor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Minor, (void*)(&value));
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600B7D3 RID: 47059 RVA: 0x002DA088 File Offset: 0x002D8288
		// (set) Token: 0x0600B7D4 RID: 47060 RVA: 0x0005A3D0 File Offset: 0x000585D0
		public unsafe static byte Release
		{
			get
			{
				byte result;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_Release, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_Release, (void*)(&value));
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x002DA0A4 File Offset: 0x002D82A4
		// (set) Token: 0x0600B7D6 RID: 47062 RVA: 0x0005A3DE File Offset: 0x000585DE
		public unsafe static string StageSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_StageSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_StageSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x002DA0C4 File Offset: 0x002D82C4
		// (set) Token: 0x0600B7D8 RID: 47064 RVA: 0x0005A3F0 File Offset: 0x000585F0
		public unsafe static string TrialSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VersionInfo.NativeFieldInfoPtr_TrialSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VersionInfo.NativeFieldInfoPtr_TrialSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600B7D9 RID: 47065 RVA: 0x002DA0E4 File Offset: 0x002D82E4
		// (set) Token: 0x0600B7DA RID: 47066 RVA: 0x0005A402 File Offset: 0x00058602
		public unsafe int m_major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_major)) = value;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600B7DB RID: 47067 RVA: 0x002DA10C File Offset: 0x002D830C
		// (set) Token: 0x0600B7DC RID: 47068 RVA: 0x0005A41D File Offset: 0x0005861D
		public unsafe int m_minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_minor)) = value;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x0600B7DD RID: 47069 RVA: 0x002DA134 File Offset: 0x002D8334
		// (set) Token: 0x0600B7DE RID: 47070 RVA: 0x0005A438 File Offset: 0x00058638
		public unsafe int m_release
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_release);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionInfo.NativeFieldInfoPtr_m_release)) = value;
			}
		}

		// Token: 0x04007BD5 RID: 31701
		private static readonly IntPtr NativeFieldInfoPtr_Major;

		// Token: 0x04007BD6 RID: 31702
		private static readonly IntPtr NativeFieldInfoPtr_Minor;

		// Token: 0x04007BD7 RID: 31703
		private static readonly IntPtr NativeFieldInfoPtr_Release;

		// Token: 0x04007BD8 RID: 31704
		private static readonly IntPtr NativeFieldInfoPtr_StageSuffix;

		// Token: 0x04007BD9 RID: 31705
		private static readonly IntPtr NativeFieldInfoPtr_TrialSuffix;

		// Token: 0x04007BDA RID: 31706
		private static readonly IntPtr NativeFieldInfoPtr_m_major;

		// Token: 0x04007BDB RID: 31707
		private static readonly IntPtr NativeFieldInfoPtr_m_minor;

		// Token: 0x04007BDC RID: 31708
		private static readonly IntPtr NativeFieldInfoPtr_m_release;

		// Token: 0x04007BDD RID: 31709
		private static readonly IntPtr NativeMethodInfoPtr_StaticToString_Public_Static_String_0;

		// Token: 0x04007BDE RID: 31710
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04007BDF RID: 31711
		private static readonly IntPtr NativeMethodInfoPtr_get_FullNumber_Public_Static_get_Int32_0;

		// Token: 0x04007BE0 RID: 31712
		private static readonly IntPtr NativeMethodInfoPtr_get_Number_Public_get_Int32_0;

		// Token: 0x04007BE1 RID: 31713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04007BE2 RID: 31714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Byte_Byte_Byte_0;

		// Token: 0x04007BE3 RID: 31715
		private static readonly IntPtr NativeMethodInfoPtr_Current_Public_Static_VersionInfo_0;

		// Token: 0x04007BE4 RID: 31716
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_VersionInfo_0;
	}
}
