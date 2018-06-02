// BC212364
// This code was generated by a tool.
// date: 03/05/2017 11:20:34

namespace Perpetuum.ExportedTypes
{
	[System.Flags]
	public enum EffectCategory : long
	{
		undefined = 0,
 		effcat_aggressor = 0x0000000000004000,
		effcat_blob_emission_modulator = 0x0000000010000000,
		effcat_consumable_effects = 0x0000008000000000,
		effcat_detection_stealth = 0x0000000020000000,
		effcat_eccm = 0x0000000100000000,
		effcat_eccmcureable_effects = 0x0000000200000000,
		effcat_gang_effect = 0x0000000000000040,
		effcat_gang_effect_coordinated_maneuvering = 0x0000000000100000,
		effcat_gang_effect_core_management = 0x0000000001000000,
		effcat_gang_effect_defense = 0x0000000000000080,
		effcat_gang_effect_ewar = 0x0000000000040000,
		effcat_gang_effect_fast_extraction = 0x0000000002000000,
		effcat_gang_effect_gathering = 0x0000000000000400,
		effcat_gang_effect_information = 0x0000000000000100,
		effcat_gang_effect_maintance = 0x0000000000400000,
		effcat_gang_effect_precision_firing = 0x0000000000800000,
		effcat_gang_effect_shared_dataprocessing = 0x0000000000080000,
		effcat_gang_effect_shield_calculations = 0x0000000000200000,
		effcat_gang_effect_siege = 0x0000000000000800,
		effcat_gang_effect_speed = 0x0000000000000200,
		effcat_highway = 0x0000000080000000,
		effcat_intrusion_effect = 0x0000000800000000,
		effcat_invulnerable = 0x0000000000010000,
		effcat_jamm = 0x0000000000001000,
		effcat_movement_imparing = 0x0000000000000001,
		effcat_pbs_booster_effects = 0x0000001000000000,
		effcat_pbs_engineering_aura = 0x0000020000000000,
		effcat_pbs_gap_generator_effect = 0x0000002000000000,
		effcat_pbs_industry_aura = 0x0000040000000000,
		effcat_pbs_mining_tower_effect = 0x0000004000000000,
		effcat_pbs_sensors_aura = 0x0000010000000000,
		effcat_pvp_flag = 0x0000000000002000,
		effcat_range_increasing = 0x0000000000000020,
		effcat_resists = 0x0000000000000008,
		effcat_safe_spot = 0x0000000004000000,
		effcat_sensor_amplify = 0x0000000000000002,
		effcat_sensor_supress = 0x0000000000000004,
		effcat_shield = 0x0000000000000010,
		effcat_speed_booster = 0x0000000000008000,
		effcat_tag = 0x0000000000020000,
		effcat_target_paint = 0x0000000040000000,
		effcat_teleport_effects = 0x0000000008000000,
		effcat_terrain_object_effects = 0x0000080000000000,
		effcat_zero_core_drop = 0x0000000400000000,
        effcat_zone_beta = 0x0000100000000000 //TODO beta bonus category -- might hijack other category if client cant display?
    }
}
