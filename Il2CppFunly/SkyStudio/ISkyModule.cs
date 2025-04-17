using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011D RID: 285
	public class ISkyModule : Il2CppObjectBase
	{
		// Token: 0x06001866 RID: 6246 RVA: 0x0000E054 File Offset: 0x0000C254
		// Note: this type is marked as 'beforefieldinit'.
		static ISkyModule()
		{
			Il2CppClassPointerStore<ISkyModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ISkyModule");
			ISkyModule.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Abstract_Virtual_New_Void_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISkyModule>.NativeClassPtr, 100665895);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000BC7D8 File Offset: 0x000BA9D8
		[CallerCount(0)]
		public unsafe virtual void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skyProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISkyModule.NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Abstract_Virtual_New_Void_SkyProfile_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0000E083 File Offset: 0x0000C283
		public ISkyModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForTimeOfDay_Public_Abstract_Virtual_New_Void_SkyProfile_Single_0;
	}
}
