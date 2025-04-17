using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000463 RID: 1123
	[Serializable]
	public class PID : Object
	{
		// Token: 0x06006180 RID: 24960 RVA: 0x001BCA40 File Offset: 0x001BAC40
		// Note: this type is marked as 'beforefieldinit'.
		static PID()
		{
			Il2CppClassPointerStore<PID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID>.NativeClassPtr);
			PID.NativeFieldInfoPtr_pFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "pFactor");
			PID.NativeFieldInfoPtr_iFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "iFactor");
			PID.NativeFieldInfoPtr_dFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "dFactor");
			PID.NativeFieldInfoPtr_integral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "integral");
			PID.NativeFieldInfoPtr_lastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "lastError");
			PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675692);
			PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675693);
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x001BCAFC File Offset: 0x001BACFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200893, RefRangeEnd = 200895, XrefRangeStart = 200892, XrefRangeEnd = 200893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PID(float pFactor, float iFactor, float dFactor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pFactor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x001BCB60 File Offset: 0x001BAD60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200895, RefRangeEnd = 200898, XrefRangeStart = 200895, XrefRangeEnd = 200895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Update(float setpoint, float actual, float timeFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actual;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x0002E137 File Offset: 0x0002C337
		public PID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06006184 RID: 24964 RVA: 0x001BCBC8 File Offset: 0x001BADC8
		// (set) Token: 0x06006185 RID: 24965 RVA: 0x0002E140 File Offset: 0x0002C340
		public unsafe float pFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor)) = value;
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06006186 RID: 24966 RVA: 0x001BCBF0 File Offset: 0x001BADF0
		// (set) Token: 0x06006187 RID: 24967 RVA: 0x0002E15B File Offset: 0x0002C35B
		public unsafe float iFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor)) = value;
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06006188 RID: 24968 RVA: 0x001BCC18 File Offset: 0x001BAE18
		// (set) Token: 0x06006189 RID: 24969 RVA: 0x0002E176 File Offset: 0x0002C376
		public unsafe float dFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor)) = value;
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600618A RID: 24970 RVA: 0x001BCC40 File Offset: 0x001BAE40
		// (set) Token: 0x0600618B RID: 24971 RVA: 0x0002E191 File Offset: 0x0002C391
		public unsafe float integral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral)) = value;
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x001BCC68 File Offset: 0x001BAE68
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x0002E1AC File Offset: 0x0002C3AC
		public unsafe float lastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError)) = value;
			}
		}

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeFieldInfoPtr_pFactor;

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeFieldInfoPtr_iFactor;

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeFieldInfoPtr_dFactor;

		// Token: 0x04004289 RID: 17033
		private static readonly IntPtr NativeFieldInfoPtr_integral;

		// Token: 0x0400428A RID: 17034
		private static readonly IntPtr NativeFieldInfoPtr_lastError;

		// Token: 0x0400428B RID: 17035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x0400428C RID: 17036
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0;
	}
}
