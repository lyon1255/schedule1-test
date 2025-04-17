using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000102 RID: 258
	public class IBaseKeyframe : Il2CppObjectBase
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x000AE34C File Offset: 0x000AC54C
		// Note: this type is marked as 'beforefieldinit'.
		static IBaseKeyframe()
		{
			Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "IBaseKeyframe");
			IBaseKeyframe.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665522);
			IBaseKeyframe.NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665523);
			IBaseKeyframe.NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665524);
			IBaseKeyframe.NativeMethodInfoPtr_get_interpolationCurve_Public_Abstract_Virtual_New_get_InterpolationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665525);
			IBaseKeyframe.NativeMethodInfoPtr_set_interpolationCurve_Public_Abstract_Virtual_New_set_Void_InterpolationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665526);
			IBaseKeyframe.NativeMethodInfoPtr_get_interpolationDirection_Public_Abstract_Virtual_New_get_InterpolationDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665527);
			IBaseKeyframe.NativeMethodInfoPtr_set_interpolationDirection_Public_Abstract_Virtual_New_set_Void_InterpolationDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseKeyframe>.NativeClassPtr, 100665528);
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000AE400 File Offset: 0x000AC600
		public unsafe virtual string id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x000AE444 File Offset: 0x000AC644
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x000AE48C File Offset: 0x000AC68C
		public unsafe virtual float time
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x000AE520 File Offset: 0x000AC720
		public unsafe virtual InterpolationCurve interpolationCurve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_get_interpolationCurve_Public_Abstract_Virtual_New_get_InterpolationCurve_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_set_interpolationCurve_Public_Abstract_Virtual_New_set_Void_InterpolationCurve_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x000AE56C File Offset: 0x000AC76C
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x000AE5B4 File Offset: 0x000AC7B4
		public unsafe virtual InterpolationDirection interpolationDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_get_interpolationDirection_Public_Abstract_Virtual_New_get_InterpolationDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseKeyframe.NativeMethodInfoPtr_set_interpolationDirection_Public_Abstract_Virtual_New_set_Void_InterpolationDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0000B786 File Offset: 0x00009986
		public IBaseKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_Abstract_Virtual_New_set_Void_Single_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_interpolationCurve_Public_Abstract_Virtual_New_get_InterpolationCurve_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_set_interpolationCurve_Public_Abstract_Virtual_New_set_Void_InterpolationCurve_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_get_interpolationDirection_Public_Abstract_Virtual_New_get_InterpolationDirection_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_set_interpolationDirection_Public_Abstract_Virtual_New_set_Void_InterpolationDirection_0;
	}
}
