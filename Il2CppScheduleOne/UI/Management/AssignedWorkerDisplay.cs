using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006B7 RID: 1719
	public class AssignedWorkerDisplay : MonoBehaviour
	{
		// Token: 0x06009B16 RID: 39702 RVA: 0x00275E18 File Offset: 0x00274018
		// Note: this type is marked as 'beforefieldinit'.
		static AssignedWorkerDisplay()
		{
			Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "AssignedWorkerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr);
			AssignedWorkerDisplay.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, "Icon");
			AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682369);
			AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682370);
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00275E84 File Offset: 0x00274084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275468, RefRangeEnd = 275469, XrefRangeStart = 275457, XrefRangeEnd = 275468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x00275EC8 File Offset: 0x002740C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignedWorkerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0004BF03 File Offset: 0x0004A103
		public AssignedWorkerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x00275F04 File Offset: 0x00274104
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x0004BF0C File Offset: 0x0004A10C
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006846 RID: 26694
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006847 RID: 26695
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_NPC_0;

		// Token: 0x04006848 RID: 26696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
