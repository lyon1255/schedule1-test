using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E9 RID: 1001
	public class PlayerTeleporter : MonoBehaviour
	{
		// Token: 0x0600521B RID: 21019 RVA: 0x00185028 File Offset: 0x00183228
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTeleporter()
		{
			Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr);
			PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673582);
			PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100673583);
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00185080 File Offset: 0x00183280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177379, XrefRangeEnd = 177398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x001850C4 File Offset: 0x001832C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00027148 File Offset: 0x00025348
		public PlayerTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Transform_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
