﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000218 RID: 536
	public class IGenericSaveable : Il2CppObjectBase
	{
		// Token: 0x06002C8E RID: 11406 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		// Note: this type is marked as 'beforefieldinit'.
		static IGenericSaveable()
		{
			Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "IGenericSaveable");
			IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668316);
			IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668317);
			IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668318);
			IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668319);
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000FDC48 File Offset: 0x000FBE48
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000FDC90 File Offset: 0x000FBE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124112, XrefRangeEnd = 124127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000FDCCC File Offset: 0x000FBECC
		[CallerCount(0)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000FDD1C File Offset: 0x000FBF1C
		[CallerCount(0)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00018067 File Offset: 0x00016267
		public IGenericSaveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0;
	}
}
