using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000505 RID: 1285
	public class SteerPID : Object
	{
		// Token: 0x0600711C RID: 28956 RVA: 0x001F07AC File Offset: 0x001EE9AC
		// Note: this type is marked as 'beforefieldinit'.
		static SteerPID()
		{
			Il2CppClassPointerStore<SteerPID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "SteerPID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteerPID>.NativeClassPtr);
			SteerPID.NativeFieldInfoPtr_error_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_old");
			SteerPID.NativeFieldInfoPtr_error_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_sum");
			SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677520);
			SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677521);
			SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677522);
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x001F0840 File Offset: 0x001EEA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222298, XrefRangeEnd = 222300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref error;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid_parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x001F0898 File Offset: 0x001EEA98
		[CallerCount(0)]
		public unsafe static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldAverage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueToAdd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x001F08F4 File Offset: 0x001EEAF4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteerPID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteerPID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00035BA9 File Offset: 0x00033DA9
		public SteerPID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x001F0930 File Offset: 0x001EEB30
		// (set) Token: 0x06007122 RID: 28962 RVA: 0x00035BB2 File Offset: 0x00033DB2
		public unsafe float error_old
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old)) = value;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x001F0958 File Offset: 0x001EEB58
		// (set) Token: 0x06007124 RID: 28964 RVA: 0x00035BCD File Offset: 0x00033DCD
		public unsafe float error_sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum)) = value;
			}
		}

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr_error_old;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr_error_sum;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
