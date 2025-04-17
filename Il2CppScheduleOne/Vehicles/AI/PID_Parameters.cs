using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000506 RID: 1286
	[Serializable]
	[StructLayout(2)]
	public struct PID_Parameters
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x001F0980 File Offset: 0x001EEB80
		// Note: this type is marked as 'beforefieldinit'.
		static PID_Parameters()
		{
			Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PID_Parameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr);
			PID_Parameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "P");
			PID_Parameters.NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "I");
			PID_Parameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "D");
			PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, 100677523);
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x001F0A00 File Offset: 0x001EEC00
		[CallerCount(0)]
		public unsafe PID_Parameters(float P, float I, float D)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref P;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref D;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x00035BE8 File Offset: 0x00033DE8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, ref this));
		}

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeFieldInfoPtr_I;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeFieldInfoPtr_D;

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004D46 RID: 19782
		[FieldOffset(0)]
		public float P;

		// Token: 0x04004D47 RID: 19783
		[FieldOffset(4)]
		public float I;

		// Token: 0x04004D48 RID: 19784
		[FieldOffset(8)]
		public float D;
	}
}
