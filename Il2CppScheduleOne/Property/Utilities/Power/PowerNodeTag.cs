using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200051A RID: 1306
	public class PowerNodeTag : MonoBehaviour
	{
		// Token: 0x0600744C RID: 29772 RVA: 0x001FB088 File Offset: 0x001F9288
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNodeTag()
		{
			Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNodeTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr);
			PowerNodeTag.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, "powerNode");
			PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, 100677918);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x001FB0E0 File Offset: 0x001F92E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNodeTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x000373CB File Offset: 0x000355CB
		public PowerNodeTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600744F RID: 29775 RVA: 0x001FB11C File Offset: 0x001F931C
		// (set) Token: 0x06007450 RID: 29776 RVA: 0x000373D4 File Offset: 0x000355D4
		public unsafe PowerNode powerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F69 RID: 20329
		private static readonly IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x04004F6A RID: 20330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
